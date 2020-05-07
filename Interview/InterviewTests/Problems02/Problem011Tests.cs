using Interview.Common;
using Interview.Problems02;
using NUnit.Framework;
using System;

namespace InterviewTests.Problems02
{
    [TestFixture]
    public class Problem011Tests
    {
        [Test]
        public void SolveByRecursionTest()
        {
            var rootNode = new BinaryTreeNode(8,
                new BinaryTreeNode(6,
                    new BinaryTreeNode(5),
                    new BinaryTreeNode(7)),
                new BinaryTreeNode(10,
                    new BinaryTreeNode(9),
                    new BinaryTreeNode(11)));

            Console.WriteLine(rootNode.PrintTreeByDlr());
            Problem011.SolveByRecursion(rootNode);
            Console.WriteLine(rootNode.PrintTreeByDlr());
        }

        [Test]
        public void SolveByLoopTest()
        {
            var rootNode = new BinaryTreeNode(8,
                new BinaryTreeNode(6,
                    new BinaryTreeNode(5),
                    new BinaryTreeNode(7)),
                new BinaryTreeNode(10,
                    new BinaryTreeNode(9),
                    new BinaryTreeNode(11)));

            Console.WriteLine(rootNode.PrintTreeByDlr());
            Problem011.SolveByLoop(rootNode);
            Console.WriteLine(rootNode.PrintTreeByDlr());
        }
    }
}
