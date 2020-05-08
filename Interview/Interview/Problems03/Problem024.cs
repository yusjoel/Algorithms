using System;
using System.Collections.Generic;

namespace Interview.Problems03
{
    /// <summary>
    ///     栈的 push、pop 序列
    ///     输入两个整数序列。其中一个序列表示栈的 push 顺序，判断另一个序列有没有可能是对应的 pop 顺
    ///     序。为了简单起见，我们假设 push 序列的任意两个整数都是不相等的。
    /// </summary>
    public class Problem024
    {
        public static bool Solve(List<int> pushSequence, List<int> popSequence)
        {
            if (pushSequence == null)
                throw new ArgumentNullException(nameof(pushSequence));

            if (popSequence == null)
                throw new ArgumentNullException(nameof(popSequence));

            var stack = new Stack<int>();
            int index = 0;
            foreach (int i in pushSequence)
            {
                stack.Push(i);

                while (index < popSequence.Count)
                {
                    if (stack.Peek() != popSequence[index])
                        break;

                    index++;
                    stack.Pop();

                    if (stack.Count == 0)
                        break;
                }

                if (index >= popSequence.Count)
                    break;
            }

            return index == popSequence.Count;
        }
    }
}
