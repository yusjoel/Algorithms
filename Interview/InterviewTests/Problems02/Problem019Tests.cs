using Interview.Common;
using Interview.Problems02;
using NUnit.Framework;

namespace InterviewTests.Problems02
{
    [TestFixture]
    public class Problem019Tests
    {
        [Test]
        public void SolveTest()
        {
            var list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var head = new LinkedListNode(0);
            var node = head;
            foreach (int i in list)
            {
                var nextNode = new LinkedListNode(i);
                node.NextNode = nextNode;
                node = nextNode;
            }

            var newHead = Problem019.Solve(head);
            string text = newHead.Print();
            Assert.AreEqual("9 8 7 6 5 4 3 2 1 0", text);
        }
    }
}
