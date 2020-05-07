using Interview.Common;

namespace Interview.Problems02
{
    /// <summary>
    ///     反转链表
    /// </summary>
    public class Problem019
    {
        public static LinkedListNode Solve(LinkedListNode head)
        {
            var node = head;
            LinkedListNode previousNode = null;
            while (node != null)
            {
                var nextNode = node.NextNode;
                node.NextNode = previousNode;
                previousNode = node;
                node = nextNode;
            }
            return previousNode;
        }
    }
}
