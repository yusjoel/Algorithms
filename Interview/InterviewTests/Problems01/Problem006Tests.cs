using Interview.Problems01;
using NUnit.Framework;
using System.Collections.Generic;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem006Tests
    {
        [Test]
        public void SolveTest1()
        {
            var postOrderTraversal = new List<int> { 5,7,6,9,11,10,8 };

            Assert.IsTrue(Problem006.Solve(postOrderTraversal));
        }

        [Test]
        public void SolveTest2()
        {
            var postOrderTraversal = new List<int> { 7, 4, 6, 5 };

            Assert.IsFalse(Problem006.Solve(postOrderTraversal));
        }

    }
}
