using System.Text;

namespace Interview.Problems03
{
    /// <summary>
    ///     字符串的排列
    ///     输入一个字符串，打印出该字符串中字符的所有排列。例如输入字符串 abc，则输出由字符 a、b、
    ///     c 所能排列出来的所有字符串 abc、acb、bac、bca、cab 和 cba。
    /// </summary>
    public class Problem028
    {
        private static readonly StringBuilder outputStringBuilder = new StringBuilder();

        private static readonly StringBuilder inputStringBuilder = new StringBuilder();

        public static string Solve(string input)
        {
            // 遍历整个字符串, 让所有位置的字符都和第一个位置的字符互换位置
            // 然后递归对除去第一个字符的字符串执行该操作, 直到只剩下一个字符串

            outputStringBuilder.Length = 0;
            inputStringBuilder.Length = 0;
            inputStringBuilder.Append(input);
            Permutation(inputStringBuilder, 0);

            if (outputStringBuilder.Length > 0)
                outputStringBuilder.Length--;
            return outputStringBuilder.ToString();
        }

        private static void Permutation(StringBuilder input, int startIndex)
        {
            int length = input.Length;
            if (length - startIndex <= 1)
            {
                outputStringBuilder.Append(input);
                outputStringBuilder.Append(",");
                return;
            }

            for (int i = startIndex; i < length; i++)
            {
                char temp = input[i];
                input[i] = input[startIndex];
                input[startIndex] = temp;

                Permutation(input, startIndex + 1);

                input[startIndex] = input[i];
                input[i] = temp;
            }
        }
    }
}
