using System.Collections.Generic;

namespace Interview.Problems03
{
    /// <summary>
    ///     在从 1 到 n 的正数中 1 出现的次数
    /// </summary>
    public class Problem025
    {
        private static readonly Dictionary<int, uint> powerMap = new Dictionary<int, uint>();

        public static uint Solve(uint n)
        {
            // 这道题目的难度比看起来得高
            // n = d1d2...dm (m位)
            // 将1~n拆成两部分
            // 第1部分: 1 ~ d2d3...dm
            // 第2部分: (d2d3...dm + 1) ~ d1d2...dm
            // 第1部分递归处理, 到最后只剩dm时, dm>=1, 1出现的次数为1, 反之为0
            // 第2部分, 先看2~m位, 总共10^(m-1)个数, 每一位都会出现一次1, 一共(m-1)位, 所以出现1的次数为(m-1)10^(m-2)
            // 再看d1, 如果d1 == 1, 那么多了(d2d3...dm + 1)次, 如果d1 > 1, 那么多了10^(m-1)次

            if (n == 0)
                return 0u;

            uint power = 1;
            for (int i = 0; i < 10; i++)
            {
                powerMap[i] = power;
                power *= 10;
            }

            var digits = new List<uint>();
            uint nn = n;
            while (nn > 0)
            {
                uint digit = nn % 10;
                digits.Add(digit);
                nn /= 10;
            }

            return Solve(digits, n);
        }

        private static uint Solve(List<uint> digits, uint n)
        {
            int m = digits.Count;
            uint d1 = digits[m - 1];
            if (m == 1)
                return d1 >= 1 ? 1u : 0u;

            uint p1 = n - d1 * powerMap[m - 1];
            uint count = (uint) (m - 1) * powerMap[m - 2];
            count += d1 == 1 ? p1 + 1 : powerMap[m - 1];
            digits.RemoveAt(m - 1);
            count += Solve(digits, p1);
            return count;
        }
    }
}
