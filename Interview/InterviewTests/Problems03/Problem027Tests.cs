using Interview.Common;
using Interview.Problems03;
using NUnit.Framework;

namespace InterviewTests.Problems03
{
    [TestFixture]
    public class Problem027Tests
    {
        [Test]
        public void SolveTest()
        {
            var rootNode = new BinaryTreeNode(8,
                new BinaryTreeNode(6,
                    new BinaryTreeNode(5),
                    new BinaryTreeNode(7)),
                new BinaryTreeNode(10,
                    new BinaryTreeNode(9),
                    new BinaryTreeNode(11)));

            int depth = Problem027.Solve(rootNode);
            Assert.AreEqual(3, depth);
        }
    }
}
