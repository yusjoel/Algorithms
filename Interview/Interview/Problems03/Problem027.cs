using Interview.Common;
using System;

namespace Interview.Problems03
{
    /// <summary>
    ///     二叉树的深度
    /// </summary>
    public class Problem027
    {
        public static int Solve(BinaryTreeNode node)
        {
            if (node == null)
                return 0;

            int leftDepth = Solve(node.Left);
            int rightDepth = Solve(node.Right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
