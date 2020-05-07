using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Problems02
{
    /// <summary>
    ///     最长公共子串（Longest Common Subsequence, LCS）
    ///     如果字符串一的所有字符按其在字符串中的顺序出现在另外一个字符串二中，则字符串一称之为字
    ///     符串二的子串。注意，并不要求子串（字符串一）的字符必须连续出现在字符串二中。请编写一个函数，
    ///     输入两个字符串，求它们的最长公共子串，并打印出最长公共子串。
    /// </summary>
    public class Problem020
    {
        public static string Solve(string x, string y)
        {
            // LCS[i, j]表示字符串x.Substring(0, i + 1)和y.Substring(0, j + 1)的最长公共子串长度
            // 满足以下性质:
            // 1. i < 0 或 j < 0, LCS[i, j] = 0
            // 2. x[i] == y[j], 则该值必然在公共子串中, 所以有LCS[i, j] = LCS[i - 1, j - 1] + 1
            // 3. x[i] != y[j], 那么LCS[i, j] = max(LCS[i - 1, j], LCS[i, j - 1])

            int n = x.Length;
            int m = y.Length;
            var lcs = new int[n, m];

            int GetLcs(int i, int j)
            {
                if (i < 0) return 0;
                if (j < 0) return 0;

                return lcs[i, j];
            }

            // 不需要这样三角形的扩散
            // i == 0 或者 j == 0时, LCS[i, j] = x[i] == y[j] ? 1 : 0
            // 然后直接
            // for(i = 0; i < n; i++)
            // for(j = 0; j < m; j++)
            // 此时必然能保证LCS[i-1, j-1], LCS[i-1, j], LCS[i, j-1]存在

            // 原解还使用了一个二维数组来保存方向
            // 更直观一些

            int limit = n + m - 1;
            for (int k = 0; k < limit; k++)
            for (int i = 0; i < n && i <= k; i++)
            {
                int j = k - i;
                if (j > m - 1) continue;

                if (x[i] == y[j])
                    lcs[i, j] = GetLcs(i - 1, j - 1) + 1;
                else
                    lcs[i, j] = Math.Max(GetLcs(i, j - 1), GetLcs(i - 1, j));
            }

            var list = new List<char>();
            n--;
            m--;
            while (n >= 0 && m >= 0)
                if (x[n] == y[m])
                {
                    list.Add(x[n]);
                    n--;
                    m--;
                }
                else
                {
                    int lcsOfNm = GetLcs(n, m);
                    if (lcsOfNm == 0)
                        break;

                    if (lcsOfNm == GetLcs(n - 1, m))
                        n--;
                    else
                        m--;
                }

            int count = list.Count;
            var stringBuilder = new StringBuilder();
            for (int i = count - 1; i >= 0; i--)
                stringBuilder.Append(list[i]);

            return stringBuilder.ToString();
        }
    }
}
