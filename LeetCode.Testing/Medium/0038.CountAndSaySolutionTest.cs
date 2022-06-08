using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class CountAndSaySolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void CountAndSay_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new CountAndSaySolution();

            var result = sut.CountAndSay(testCase.Num);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Num = 1,
                Result = "1"
            };
            yield return new TestCase
            {
                Num = 4,
                Result = "1211"
            };
            yield return new TestCase
            {
                Num = 5,
                Result = "111221"
            };
        }

        public class TestCase
        {
            public int Num { get; set; }

            public string Result { get; set; }
        }
    }
}