using Interview.Common;
using System.Collections.Generic;
using System.Text;

namespace Interview.Problems02
{
    /// <summary>
    ///     从上往下遍历二元树
    /// </summary>
    public class Problem012
    {
        public static string Solve(BinaryTreeNode rootNode)
        {
            var stringBuilder = new StringBuilder();
            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(rootNode);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                stringBuilder.Append(node.Value).Append(' ');

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
