using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Problems03
{
    /// <summary>
    ///     和为 n 连续正数序列
    ///     输入一个正数 n，输出所有和为 n 连续正数序列。
    ///     例如输入 15，由于 1+2+3+4+5=4+5+6=7+8=15，所以输出 3 个连续序列 1-5、4-6 和 7-8。
    /// </summary>
    public class Problem026
    {
        public static string ClearlySolve(uint n)
        {
            // 原解答, 不能算是更好的解, 只能说是更清晰的解
            // 令start = 1, end = 2, 计算他们的和sum
            // 如果sum < n, start++, 如果sum > n, end--
            // 如果sum == n, 记录start, end, 然后start++, end--
            // 直到start > n / 2, 因为数列至少有两个数, start, start + 1

            // 对于n, 令m = sqrt(2n)
            // start = 1, end = m
            // 最后移动到 start = n/2, end = n/2+1
            // 可见需要执行n - m步, 时间复杂度O(n)

            uint start = 1;
            double sqrt = Math.Sqrt(n * 2);
            double ceiling = Math.Floor(sqrt);
            uint end = (uint) ceiling - 1;
            uint currentSum = (start + end) * (end - start + 1) / 2;

            var solution = new List<Tuple<uint, uint>>();

            uint half = n / 2;
            while (start <= half)
                if (currentSum == n)
                {
                    solution.Add(new Tuple<uint, uint>(start, end));
                    currentSum -= start;
                    start++;
                    end++;
                    currentSum += end;
                }
                else if (currentSum > n)
                {
                    currentSum -= start;
                    start++;
                }
                else
                {
                    end++;
                    currentSum += end;
                }

            solution.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            var stringBuilder = new StringBuilder();
            foreach (var tuple in solution)
                stringBuilder.AppendFormat("{0}-{1},", tuple.Item1, tuple.Item2);
            if (stringBuilder.Length > 0)
                stringBuilder.Length--;
            return stringBuilder.ToString();
        }

        public static string Solve(uint n)
        {
            // i + (i+1) + ... + (i+k) = (2i+k)*(k+1)/2 (i > 0, k > 0)
            // 15 = 3*5
            // a. k+1 = 3
            // b. k+1 = 5
            // c. k+1 = 1 * 2
            // d. k+1 = 3 * 2
            // e. k+1 = 5 * 2

            // n = (2i+k)*(k+1)/2 > (k+1)^2/2
            // k + 1 < sqrt(2n)

            var solution = new List<Tuple<uint, uint>>();

            void Add(uint n1, uint n2)
            {
                foreach (var tuple in solution)
                    if (tuple.Item1 == n1)
                        return;

                solution.Add(new Tuple<uint, uint>(n1, n2));
            }

            // 这里明显时间复杂度O(sqrt(2n))
            // 再考虑到只处理因数, 复杂度更低

            uint sqrt = (uint) Math.Ceiling(Math.Sqrt(2.0 * n));
            for (uint factor = 1; factor < sqrt; factor++)
            {
                if (n % factor != 0) continue;

                // k + 1 = factor
                uint k = factor - 1;
                uint t = n / factor * 2;
                uint i;
                if (k > 0 && k % 2 == 0 && t > k)
                {
                    i = (t - k) / 2;
                    Add(i, k);
                }

                // k + 1 = factor * 2
                k = factor * 2 - 1;
                t = n / factor;
                if (k > 0 && t > k && (t - k) % 2 == 0)
                {
                    i = (t - k) / 2;
                    Add(i, k);
                }
            }

            solution.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            var stringBuilder = new StringBuilder();
            foreach (var tuple in solution)
                stringBuilder.AppendFormat("{0}-{1},", tuple.Item1, tuple.Item1 + tuple.Item2);
            if (stringBuilder.Length > 0)
                stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
