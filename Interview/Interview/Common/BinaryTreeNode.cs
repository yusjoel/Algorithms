using System.Text;

namespace Interview.Common
{
    /// <summary>
    ///     二叉树节点
    /// </summary>
    public class BinaryTreeNode
    {
        private static readonly StringBuilder stringBuilder = new StringBuilder();

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

        /// <summary>
        ///     前序遍历输出树
        /// </summary>
        /// <returns></returns>
        public string PrintTreeByDlr()
        {
            stringBuilder.Length = 0;
            PrintTreeByDlr(this, 0, stringBuilder);
            return stringBuilder.ToString();
        }

        private static void PrintTreeByDlr(BinaryTreeNode node, int tab, StringBuilder stringBuilder)
        {
            if (node == null) return;

            AddTab(stringBuilder, tab);
            stringBuilder.AppendLine(node.Value.ToString());
            PrintTreeByDlr(node.Left, tab + 4, stringBuilder);
            PrintTreeByDlr(node.Right, tab + 4, stringBuilder);
        }

        public static void AddTab(StringBuilder stringBuilder, int count)
        {
            for (int i = 0; i < count; i++)
                stringBuilder.Append(' ');
        }
    }
}
