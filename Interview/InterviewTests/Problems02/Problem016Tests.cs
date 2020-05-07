using Interview.Problems02;
using NUnit.Framework;

namespace InterviewTests.Problems02
{
    [TestFixture]
    public class Problem016Tests
    {
        [TestCase(2u, 10u, "1024")]
        public void FastPowerTest(ulong x, ulong y, string expected)
        {
            var power = Problem016.FastPower(x, y);
            Assert.AreEqual(expected, power.ToString());
        }

        [TestCase(3u, "2")]
        [TestCase(5u, "5")]
        [TestCase(6u, "8")]
        [TestCase(7u, "13")]
        [TestCase(8u, "21")]
        [TestCase(11u, "89")]
        [TestCase(21u, "10946")]
        [TestCase(41u, "165580141")]
        [TestCase(81u, "37889062373143906")]
        [TestCase(99u, "218922995834555169026")]
        public void FastFibonacciTest(ulong n, string expected)
        {
            var fibonacci = Problem016.FastFibonacci(n);
            Assert.AreEqual(expected, fibonacci.ToString());
        }
    }
}
