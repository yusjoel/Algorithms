using System.Collections.Generic;

namespace Interview.Problems02
{
    public class QueueWithTwoStack<T>
    {
        private readonly Stack<T> dequeueStack = new Stack<T>();

        private readonly Stack<T> enqueueStack = new Stack<T>();

        public void Enqueue(T item)
        {
            enqueueStack.Push(item);
        }

        public T Dequeue()
        {
            if (dequeueStack.Count == 0)
            {
                while (enqueueStack.Count > 0)
                {
                    var i = enqueueStack.Pop();
                    dequeueStack.Push(i);
                }
            }
            return dequeueStack.Pop();
        }
    }

    /// <summary>
    ///     用两个栈实现队列
    /// </summary>
    public class Problem018
    {
        // 一个栈用来进队, 另一个栈用来出队
        // 我一开始的想法是
        // 1. 出队的时候把进队的元素都压进出队的栈
        // 2. 进队的时候如果进队的栈是空, 那么把出队的栈再压回来
        // 但其实不用那么复杂
        // 1. 进队的时候压进进队的栈
        // 2. 出队的时候如果出队的栈是空, 那么把进队的栈里面的元素都压进出队的栈
    }
}
