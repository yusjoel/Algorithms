using System;
using System.Collections.Generic;

namespace Interview.Problems01
{
    /// <summary>
    ///     查找最小的 k 个元素
    /// </summary>
    public class Problem005
    {
        public static List<int> Solve(List<int> numbers, int k)
        {
            // O(nLgn)
            var copyNumbers = new List<int>(numbers);
            copyNumbers.Sort();
            return copyNumbers.GetRange(0, k);
        }

        public static List<int> BetterSolve(List<int> numbers, int k)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            if (k <= 0)
                throw new ArgumentOutOfRangeException(nameof(k));

            if (numbers.Count <= k)
                return numbers;

            // 用一个最大堆来保存最小的k个数, 可以把时间复杂度降低到O(nLgk)
            var maxHeap = new MaxHeap(k);
            foreach (int number in numbers)
                if (maxHeap.Count < k)
                {
                    maxHeap.Push(number);
                }
                else if (maxHeap.Peek() > number)
                {
                    maxHeap.Pop();
                    maxHeap.Push(number);
                }

            var list = new List<int>();
            for (int i = 0; i < k; i++)
                list.Insert(0, maxHeap.Pop());

            return list;
        }

        /// <summary>
        ///     一个不考虑扩容的最大堆
        /// </summary>
        private class MaxHeap
        {
            private readonly int[] heap;

            private readonly int size;

            public MaxHeap(int size)
            {
                this.size = size;
                heap = new int[size];
            }

            public int Count { get; private set; }

            public void Push(int value)
            {
                if (Count == size)
                    throw new Exception("heap is full");

                heap[Count] = value;
                ShiftUp(Count, value);
                Count++;
            }

            /// <summary>
            ///     让最大的值向顶部升上去
            /// </summary>
            /// <param name="index"></param>
            /// <param name="value"></param>
            private void ShiftUp(int index, int value)
            {
                while (index > 0)
                {
                    int parent = (index - 1) / 2;
                    if (heap[parent] < value)
                    {
                        heap[index] = heap[parent];
                        heap[parent] = value;
                        index = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public int Pop()
            {
                if (Count == 0) throw new Exception("heap is empty");

                int value = heap[0];
                heap[0] = heap[Count - 1];
                Count--;
                ShiftDown(0, heap[0]);
                return value;
            }

            public int Peek()
            {
                if (Count == 0)
                    throw new Exception("heap is empty");

                return heap[0];
            }

            /// <summary>
            ///     让小的值和左右子节点中较大的那个交换
            /// </summary>
            /// <param name="index"></param>
            /// <param name="value"></param>
            private void ShiftDown(int index, int value)
            {
                int half = Count / 2;
                while (index <= half)
                {
                    int left = index * 2 + 1;
                    int childIndex = left;
                    int childValue;

                    // 记录左节点的值, 左节点都没有, 直接结束
                    if (left < Count)
                        childValue = heap[left];
                    else
                        break;

                    // 看看有没有右节点, 获取其中较大者
                    int right = index * 2 + 2;
                    if (right < Count)
                        if (heap[right] > childValue)
                        {
                            childValue = heap[right];
                            childIndex = right;
                        }

                    // 当前值比子节点都大, 那么结束
                    if (value >= childValue)
                        break;

                    // 和子节点交换, 继续下降
                    heap[index] = childValue;
                    heap[childIndex] = value;
                    index = childIndex;
                }
            }
        }
    }
}