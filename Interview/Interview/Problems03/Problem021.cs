using System;
using System.Text;

namespace Interview.Problems03
{
    /// <summary>
    ///     左旋转字符串
    ///     定义字符串的左旋转操作：把字符串前面的若干个字符移动到字符串的尾部。如把字符串 abcdef
    ///     左旋转 2 位得到字符串 cdefab。请实现字符串左旋转的函数。要求时间对长度为 n 的字符串操作的复杂度
    ///     为 O(n)，辅助内存为 O(1)。
    /// </summary>
    public class Problem021
    {
        public static void Solve(StringBuilder stringBuilder, int k)
        {
            if (stringBuilder == null)
                throw new ArgumentNullException(nameof(stringBuilder));

            if (k < 0)
                throw new ArgumentOutOfRangeException(nameof(k));

            int n = stringBuilder.Length;
            if (n == 0 || n == 1)
                return;

            k = k % n;
            if (k == 0)
                return;

            int count = 0;
            for (int i = 0; i < k; i++)
            {
                int startIndex = i;
                int index = startIndex;
                char currentChar = stringBuilder[index];

                do
                {
                    int nextIndex = (index - k + n) % n;
                    char nextChar = stringBuilder[nextIndex];
                    stringBuilder[nextIndex] = currentChar;
                    currentChar = nextChar;
                    index = nextIndex;
                    count++;
                } while (index != startIndex);

                if (count == n)
                    break;
            }
        }

        public static void BetterSolve(StringBuilder input, int k)
        {
            // input = s0s1...sn-1
            //       = x0x1...xk-1y0y1..yn-k-1
            // 定义操作Reverse(s)代表将字符串翻转, 记做s'
            // input = XY
            // output = YX = (YX)'' = (X'Y')'

            // 检查的代码:略
            int n = input.Length;
            Reverse(input, 0, k - 1);
            Reverse(input, k, n - 1);
            Reverse(input, 0, n - 1);
        }

        private static void Reverse(StringBuilder stringBuilder, int startIndex, int endIndex)
        {
            int i = startIndex;
            int j = endIndex;
            while (j > i)
            {
                char ch = stringBuilder[i];
                stringBuilder[i] = stringBuilder[j];
                stringBuilder[j] = ch;
                i++;
                j--;
            }
        }
    }
}
