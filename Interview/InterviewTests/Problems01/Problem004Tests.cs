using Interview.Common;
using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem004Tests
    {
        [Test]
        public void SolveTest()
        {
            var rootNode = new BinaryTreeNode(10,
                new BinaryTreeNode(5,
                    new BinaryTreeNode(4),
                    new BinaryTreeNode(7)),
                new BinaryTreeNode(12));

            string pathList = Problem004.Solve(rootNode, 22);
            Assert.AreEqual("10,5,7\r\n" + "10,12\r\n", pathList);
        }
    }
}