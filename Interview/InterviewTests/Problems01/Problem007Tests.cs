using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    internal class Problem007Tests
    {
        [Test]
        public void SolveTest()
        {
            string phrase = "I am a student.";
            Assert.AreEqual("student. a am I", Problem007.Solve(phrase));
        }
    }
}
