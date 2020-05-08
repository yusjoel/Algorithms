using Interview.Problems03;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace InterviewTests.Problems03
{
    [TestFixture()]
    public class Problem026Tests
    {
        [TestCase(15u, "1-5,4-6,7-8")]
        [TestCase(100u, "9-16,18-22")]
        [TestCase(5050u, "1-100,190-214,243-262,1008-1012,1261-1264")]
        public void SolveTest(uint n, string expected)
        {
            string solution = Problem026.Solve(n);
            Assert.AreEqual(expected, solution);
        }

        [TestCase(15u, "1-5,4-6,7-8")]
        [TestCase(100u, "9-16,18-22")]
        [TestCase(5050u, "1-100,190-214,243-262,1008-1012,1261-1264")]
        public void CleverSolveTest(uint sum, string expected)
        {
            string solution = Problem026.ClearlySolve(sum);
            Assert.AreEqual(expected, solution);
        }

        [Test]
        public void PerformanceTest()
        {
            uint sum = 2112532500u;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string solution1 = Problem026.Solve(sum);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Restart();
            string solution2 = Problem026.ClearlySolve(sum);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            Assert.AreEqual(solution1, solution2);
            Console.WriteLine(solution1);
        }
    }
}
