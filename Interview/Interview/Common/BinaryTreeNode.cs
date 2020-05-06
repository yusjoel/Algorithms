namespace Interview.Common
{
    /// <summary>
    ///     二叉树节点
    /// </summary>
    public class BinaryTreeNode
    {
        public BinaryTreeNode Left;

        public BinaryTreeNode Right;

        public int Value;

        public BinaryTreeNode(int value) : this(value, null, null)
        {
        }

        public BinaryTreeNode(int value, BinaryTreeNode left, BinaryTreeNode right)
        {
            Value = value;
            Right = right;
            Left = left;
        }

        public bool IsLeaf()
        {
            return Right == null && Left == null;
        }
    }
}
