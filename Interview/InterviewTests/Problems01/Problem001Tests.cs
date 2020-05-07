using System;
using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem001Tests
    {
        [Test]
        public void HandleNodeTest()
        {
            var node = new Problem001.Node(10,
                new Problem001.Node(6, new Problem001.Node(4), new Problem001.Node(8)),
                new Problem001.Node(14, new Problem001.Node(12), new Problem001.Node(16))
            );

            string tree = Problem001.PrintTree(node);
            Console.WriteLine(tree);

            Problem001.HandleNode(node, out var leftNode, out var rightNode);
            string linkedList = Problem001.PrintLinkedList(leftNode, rightNode);
            Console.WriteLine(linkedList);

            Assert.AreEqual("4 -> 6 -> 8 -> 10 -> 12 -> 14 -> 16 -> End\r\n" +
                "16 -> 14 -> 12 -> 10 -> 8 -> 6 -> 4 -> End\r\n"
                , linkedList);
        }
    }
}