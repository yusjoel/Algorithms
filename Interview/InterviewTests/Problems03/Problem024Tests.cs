using Interview.Problems03;
using NUnit.Framework;
using System.Collections.Generic;

namespace InterviewTests.Problems03
{
    [TestFixture]
    public class Problem024Tests
    {
        [Test]
        public void SolveTest()
        {
            var pushSequence = new List<int> { 1, 2, 3, 4 };
            var popSequence = new List<int> { 1, 3, 2, 4 };
            Assert.IsTrue(Problem024.Solve(pushSequence, popSequence));
        }
    }
}
