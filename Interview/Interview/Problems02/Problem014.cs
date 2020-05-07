namespace Interview.Problems02
{
    /// <summary>
    /// 圆圈中最后剩下的数字
    /// n 个数字（0,1,…,n-1）形成一个圆圈，
    /// 从数字 0 开始，每次从这个圆圈中删除第 m 个数字（第一个为当前数字本身，第二个为当前数字的下一个数字）。
    /// 当一个数字删除后，从被删除数字的下一个继续删除第 m 个数字。求出在这个圆圈中剩下的最后一个数字。
    /// </summary>
    public class Problem014
    {
        public static int Solve(int n, int m)
        {
            /*
             * josephus(n, k) = (josephus(n - 1, k) + k) % n
             * josephus(n, k) 表示的是最后存活的位置。
             * 当有n个人时，第一次杀掉的是第k个人。
             * 我们假设从被杀掉的人的下一个重新编号，从1开始。
             * 所以josephus(n - 1, k)表示的就是n-1个人的情况最后的结果。
             */

            if (n == 1) return 0;

            return (Solve(n - 1, m) + m) % n;
        }

    }
}
