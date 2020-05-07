namespace Interview.Problems02
{
    /// <summary>
    ///     在一个字符串中找到第一个只出现一次的字符。
    ///     如输入 abaccdeff，则输出 b。
    /// </summary>
    public class Problem013
    {
        public static char Solve(string input)
        {
            var counts = new int[256];
            foreach (char c in input)
                counts[c]++;

            foreach (char c in input)
                if (counts[c] == 1)
                    return c;

            return ' ';
        }
    }
}
