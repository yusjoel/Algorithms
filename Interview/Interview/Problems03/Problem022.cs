namespace Interview.Problems03
{
    /// <summary>
    ///     整数的二进制表示中 1 的个数
    ///     输入一个整数，求该整数的二进制表达中有多少个 1。例如输入 10，由于其二进制表示为 1010，有
    ///     两个 1，因此输出 2。
    /// </summary>
    public class Problem022
    {
        public static int Solve(int n)
        {
            // 这题唯一的陷阱在于负数
            // 1. 转成uint
            // 2. 不要对传入的数进行操作, 而是对1反复的向左位移, 要注意的是也要使用uint
            // 3. 一个很巧妙的方法 n = (n - 1) & n
            // 假设数字n的最低位1在位置i, 那么n = b0b1...bi-1 100...0
            // n - 1 = b0b1...bi-1 011...1
            // (n - 1) & n = b0b1...bi-1 000...0
            // 可见每做一次该操作就可以消除最后一个1, 直到n == 0

            uint m = (uint) n;
            int count = 0;
            while (m > 0)
            {
                if ((m & 1) == 1)
                    count++;
                m >>= 1;
            }

            return count;
        }
    }
}
