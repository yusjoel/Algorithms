using System.Text;

namespace Interview.Common
{
    public class LinkedListNode
    {
        private static readonly StringBuilder stringBuilder = new StringBuilder();

        public LinkedListNode NextNode;

        public int Value;

        public LinkedListNode(int value)
        {
            Value = value;
        }

        public string Print()
        {
            stringBuilder.Length = 0;
            var node = this;
            while (node != null)
            {
                stringBuilder.Append(node.Value).Append(' ');
                node = node.NextNode;
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
