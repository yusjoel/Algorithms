using Interview.Problems02;
using NUnit.Framework;

namespace InterviewTests.Problems02
{
    [TestFixture]
    public class Problem013Tests
    {
        [Test]
        public void SolveTest()
        {
            char ch = Problem013.Solve("abaccdeff");
            Assert.AreEqual('b', ch);
        }
    }
}
