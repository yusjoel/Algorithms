using Interview.Common;
using Interview.Problems02;
using NUnit.Framework;

namespace InterviewTests.Problems02
{
    [TestFixture()]
    public class Problem012Tests
    {
        [Test()]
        public void SolveTest()
        {
            var rootNode = new BinaryTreeNode(8,
                new BinaryTreeNode(6,
                    new BinaryTreeNode(5),
                    new BinaryTreeNode(7)),
                new BinaryTreeNode(10,
                    new BinaryTreeNode(9),
                    new BinaryTreeNode(11)));

            string solution = Problem012.Solve(rootNode);
            Assert.AreEqual("8 6 10 5 7 9 11", solution);
        }
    }
}
