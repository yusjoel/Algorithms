using System;

namespace Interview.Problems03
{
    /// <summary>
    ///     跳台阶问题
    ///     一个台阶总共有 n 级，如果一次可以跳 1 级，也可以跳 2 级。求总共有多少总跳法，并分析算法的
    ///     时间复杂度。
    /// </summary>
    public class Problem023
    {
        public static int Solve(int n)
        {
            // 设f(n)为跳法数, 最后有两种情况, 跳1级, 跳2级, 所以
            // f(n) = f(n-1) + f(n-2)
            // 这就是斐波那契数列, 并且f(n) = fibonacci(n + 1)
            // 这里写一个非递归的实现

            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (n == 1)
                return 1;

            if (n == 2)
                return 2;

            int f1 = 1;
            int f2 = 2;
            for (int i = 2; i < n; i++)
            {
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }

            return f2;
        }
    }
}
