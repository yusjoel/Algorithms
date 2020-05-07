using System;
using System.Collections.Generic;

namespace Interview.Problems01
{
    /// <summary>
    ///     判断整数序列是不是二元查找树的后序遍历结果
    /// </summary>
    public class Problem006
    {
        // 居然连中两枪, 第一考察后序遍历, 前序/中序/后序, 指父节点在左右子节点的位置, 后序是LRD
        // 第二, 题目问的是给出一个列表, 问这个列表是不是一个二叉查找树通过后序遍历能产生的
        // 而不是给出一个二叉查找树和一个列表, 问你后序遍历的结果是不是它

        // 下面说一下后序遍历的特性
        // a. 最后一个数必然是父节点
        // b. 从左侧开始小于父节点的部分是左子树, 其他部分是右子树
        // c. 右子树中不能有元素小于父节点
        // d. 左子树和右子树也都是后序遍历的结果

        public static bool Solve(List<int> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return IsPostOrderTraversal(numbers, 0, numbers.Count - 1);
        }

        private static bool IsPostOrderTraversal(List<int> numbers, int start, int end)
        {
            if (end - start <= 1) return true;

            int parent = numbers[end];
            int leftStart = start;
            int leftEnd = start;
            if (numbers[start] < parent)
            {
                while (leftEnd + 1 < end && numbers[leftEnd + 1] < parent) leftEnd++;
                if (!IsPostOrderTraversal(numbers, leftStart, leftEnd))
                    return false;
            }

            int rightStart = leftEnd + 1;
            int rightEnd = end - 1;
            for (int i = rightStart; i < rightEnd; i++)
                if (numbers[i] < parent)
                    return false;

            return IsPostOrderTraversal(numbers, rightStart, rightEnd);
        }

        //public static bool Solve(BinaryTreeNode rootNode, List<int> postOrderTraversal)
        //{
        //    int index = 0;
        //    return PostOrderTraverse(rootNode, ref index, postOrderTraversal) && index == postOrderTraversal.Count;
        //}

        //private static bool PostOrderTraverse(BinaryTreeNode node, ref int index, List<int> postOrderTraversal)
        //{
        //    if (node == null)
        //        return true;

        //    if (node.Right != null)
        //        if (!PostOrderTraverse(node.Right, ref index, postOrderTraversal))
        //            return false;

        //    if (index < postOrderTraversal.Count && postOrderTraversal[index] == node.Value)
        //        index++;
        //    else
        //        return false;

        //    if (node.Left != null)
        //        if (!PostOrderTraverse(node.Left, ref index, postOrderTraversal))
        //            return false;

        //    return true;
        //}
    }
}