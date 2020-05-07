using System.Collections.Generic;
using System.Text;
using Interview.Common;

namespace Interview.Problems01
{
    public class Problem004
    {
        public static string Solve(BinaryTreeNode rootNode, int number)
        {
            var stringBuilder = new StringBuilder();
            var path = new List<int>();
            Traverse(rootNode, path, number, stringBuilder);
            return stringBuilder.ToString();
        }

        private static void Traverse(BinaryTreeNode node, List<int> path, int number, StringBuilder stringBuilder)
        {
            if (node == null)
                return;

            if (node.IsLeaf())
            {
                if (node.Value == number)
                {
                    foreach (int i in path)
                        stringBuilder.Append(i).Append(',');
                    stringBuilder.AppendLine(number.ToString());
                }
                return;
            }
            path.Add(node.Value);
            if (node.Left != null)
                Traverse(node.Left, path, number - node.Value, stringBuilder);
            if (node.Right != null)
                Traverse(node.Right, path, number - node.Value, stringBuilder);
            path.RemoveAt(path.Count - 1);
        }
    }
}