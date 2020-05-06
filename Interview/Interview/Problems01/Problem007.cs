using System.Collections.Generic;
using System.Text;

namespace Interview.Problems01
{
    /// <summary>
    ///     翻转句子中单词的顺序
    /// </summary>
    public class Problem007
    {
        public static string Solve(string phrase)
        {
            // 本题是一道针对C的考题, 基本思路是先翻转整个句子
            // 然后以空格分隔, 翻转各个词组

            var substrings = phrase.Split(' ');
            var stack = new Stack<string>();
            foreach (string substring in substrings)
                stack.Push(substring);
            var stringBuilder = new StringBuilder();
            foreach (string s in stack)
                stringBuilder.Append(s).Append(" ");
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
