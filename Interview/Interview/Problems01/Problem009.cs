using System;
using Interview.Common;

namespace Interview.Problems01
{
    /// <summary>
    ///     查找链表中倒数第 k 个结点
    /// </summary>
    internal class Problem009
    {
        public static LinkedListNode Solve(LinkedListNode first, int k)
        {
            // 方案1: 先遍历1次, 获取总长度n, 再遍历一次, 取得n - k - 1个节点
            // 方案2: 遍历, 压栈, 然后再出栈k次
            // 方案3: 用两个相隔k的指针向后移动
            // 类似的题目还可以转成, 获取链表中间的节点(偶数个节点取中间两个的前一个)

            var p1 = first;
            var p2 = first;
            for (int i = 0; i < k; i++)
            {
                if (p1 == null)
                    throw new Exception("list count < k");

                p1 = p1.NextNode;
            }

            while (p1 != null)
            {
                p1 = p1.NextNode;
                p2 = p2.NextNode;
            }
            return p2;
        }
    }
}