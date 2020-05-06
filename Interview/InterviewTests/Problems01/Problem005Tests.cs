using Interview.Problems01;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem005Tests
    {
        [TestCase(10, 4)]
        public void SolveTest2(int n, int k)
        {
            var random = new Random((int) DateTime.Now.Ticks);
            var numbers = new List<int>();
            for (int i = 0; i < n; i++) numbers.Add(random.Next());

            var expected = Problem005.Solve(numbers, k);
            var solution = Problem005.BetterSolve(numbers, k);
            Assert.AreEqual(expected, solution);
        }

        [Test]
        public void SolveTest1()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var expected = Problem005.Solve(numbers, 4);
            var solution = Problem005.BetterSolve(numbers, 4);
            Assert.AreEqual(expected, solution);
        }
    }
}
