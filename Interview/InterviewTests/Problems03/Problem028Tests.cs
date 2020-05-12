using Interview.Problems03;
using NUnit.Framework;

namespace InterviewTests.Problems03
{
    [TestFixture]
    public class Problem028Tests
    {
        [Test]
        public void SolveTest()
        {
            string solution = Problem028.Solve("abc");
            Assert.AreEqual("abc,acb,bac,bca,cba,cab", solution);
        }
    }
}
