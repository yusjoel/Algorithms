using System;
using System.Collections.Generic;

namespace Interview.Problems01
{
    /// <summary>
    ///     求 1+2+...+n
    ///     要求不能使用乘除法、for、while、if、else、switch、case 等关键字以及条件判断语句（A? B:C）。
    /// </summary>
    public class Problem008
    {
        // 本质就是想办法替代if
        // 使用a && b, a || b来代替是一种方案
        // 用字典也可以

        public static int Solve(int n)
        {
            int sum = 0;
            Sum(n, ref sum);
            return sum;
        }

        public static int Solve2(int m)
        {
            var dictionary = new Dictionary<bool, Func<int, int>>();
            dictionary[true] = n => n + dictionary[n - 1 > 0](n - 1);
            dictionary[false] = n => 0;
            return dictionary[true](m);
        }

        private static bool Sum(int n, ref int sum)
        {
            sum += n;
            return n <= 0 || Sum(n - 1, ref sum);
        }
    }
}