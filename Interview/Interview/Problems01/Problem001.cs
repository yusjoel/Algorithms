using System.Text;

namespace Interview.Problems01
{
    /// <summary>
    ///     把二元查找树转变成排序的双向链表
    /// </summary>
    public class Problem001
    {
        public static string PrintTree(Node node)
        {
            var stringBuilder = new StringBuilder();
            PrintTreeClr(node, 0, stringBuilder);
            return stringBuilder.ToString();
        }

        private static void PrintTreeClr(Node node, int tab, StringBuilder stringBuilder)
        {
            if (node == null) return;

            AddTab(stringBuilder, tab);
            stringBuilder.AppendLine(node.Value.ToString());
            PrintTreeClr(node.Left, tab + 4, stringBuilder);
            PrintTreeClr(node.Right, tab + 4, stringBuilder);
        }

        public static string PrintLinkedList(Node leftNode, Node rightNode)
        {
            var stringBuilder = new StringBuilder();
            var node = leftNode;
            while (node != null)
            {
                stringBuilder.Append(node.Value.ToString());
                stringBuilder.Append(" -> ");
                node = node.Right;
            }
            stringBuilder.AppendLine("End");

            node = rightNode;
            while (node != null)
            {
                stringBuilder.Append(node.Value.ToString());
                stringBuilder.Append(" -> ");
                node = node.Left;
            }
            stringBuilder.AppendLine("End");
            return stringBuilder.ToString();
        }

        public static void AddTab(StringBuilder stringBuilder, int count)
        {
            for (int i = 0; i < count; i++) stringBuilder.Append(' ');
        }

        public static void HandleNode(Node node, out Node leftNode, out Node rightNode)
        {
            if (node == null)
            {
                leftNode = null;
                rightNode = null;
                return;
            }

            if (node.Left == null)
            {
                leftNode = node;
            }
            else
            {
                HandleNode(node.Left, out var leftLeftNode, out var leftRightNode);
                node.Left = leftRightNode;
                leftRightNode.Right = node;
                leftNode = leftLeftNode;
            }

            if (node.Right == null)
            {
                rightNode = node;
            }
            else
            {
                HandleNode(node.Right, out var rightLeftNode, out var rightRightNode);
                node.Right = rightLeftNode;
                rightLeftNode.Left = node;
                rightNode = rightRightNode;
            }
        }

        public class Node
        {
            public Node Left;

            public Node Right;

            public int Value;

            public Node(int value) : this(value, null, null)
            {
            }

            public Node(int value, Node left, Node right)
            {
                Value = value;
                Right = right;
                Left = left;
            }
        }
    }
}
