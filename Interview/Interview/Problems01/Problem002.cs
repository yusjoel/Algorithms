using System;
using System.Collections.Generic;

namespace Interview.Problems01
{
    /// <summary>
    ///     设计包含 min 函数的栈
    ///     本题有一个坑, 就是对于所谓"得到"最小项的理解, 这个得到并不是将最小项出栈, 只是查看而已
    ///     所以也不需要建立上下关系, 只要记录每一个状态下的最小值是什么就行
    /// </summary>
    public class Problem002
    {
        public class StackWithMin<T> where T : IComparable
        {
            private T min;

            private readonly Stack<T> minStack = new Stack<T>();

            private readonly Stack<T> stack = new Stack<T>();

            public void Push(T item)
            {
                if (stack.Count == 0)
                    min = item;
                else if (min.CompareTo(item) > 0)
                    min = item;

                stack.Push(item);
                minStack.Push(min);
            }

            public T Pop()
            {
                minStack.Pop();
                return stack.Pop();
            }

            public T Min()
            {
                return minStack.Peek();
            }

            public T Peek()
            {
                return stack.Peek();
            }
        }

        public static void Solve()
        {

        }

        //public class Node
        //{
        //    public Node Down;

        //    public Node Up;

        //    public int Value;
        //}

        //public class Stack
        //{
        //    private Node stackTop;

        //    private Node min;

        //    public void Push(Node node)
        //    {
        //        node.Down = stackTop;
        //        if (stackTop != null)
        //            stackTop.Up = node;
        //        stackTop = node;

        //        if (min == null)
        //            min = node;
        //        else if (min.Value > node.Value)
        //            min = node;
        //    }

        //    public Node Pop()
        //    {
        //        if (stackTop == null)
        //            return null;

        //        var node = stackTop;
        //        stackTop = node.Down;
        //        node.Down = null;
        //        stackTop.Up = null;

        //        // next Min??

        //        return node;
        //    }

        //    public Node Min()
        //    {
        //        if (min.Up != null)
        //            min.Up.Down = min.Down;
        //        if (min.Down != null)
        //            min.Down.Up = min.Up;
        //        if (min == stackTop)
        //            stackTop = min.Down;
        //        min.Down = null;
        //        min.Up = null;

        //        // next Min??

        //        return min;
        //    }
        //}
    }
}
