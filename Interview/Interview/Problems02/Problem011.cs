using Interview.Common;
using System.Collections.Generic;

namespace Interview.Problems02
{
    /// <summary>
    ///     求二元查找树的镜像
    /// </summary>
    public class Problem011
    {
        public static void SolveByRecursion(BinaryTreeNode node)
        {
            if (node == null) return;

            var leftNode = node.Left;
            node.Left = node.Right;
            node.Right = leftNode;

            if (node.Left != null)
                SolveByRecursion(node.Left);
            if (node.Right != null)
                SolveByRecursion(node.Right);
        }

        public static void SolveByLoop(BinaryTreeNode rootNode)
        {
            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(rootNode);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                var leftNode = node.Left;
                node.Left = node.Right;
                node.Right = leftNode;
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}
