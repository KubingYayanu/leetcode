using LeetCode.Library.Hard;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Hard
{
    [TestFixture]
    public class RegularExpressionMatchingTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void IsMatch_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new RegularExpressionMatching();

            var result = sut.IsMatch(testCase.String, testCase.Pattern);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                String = "aa",
                Pattern = "a",
                Result = false
            };
            yield return new TestCase
            {
                String = "aa",
                Pattern = "a*",
                Result = true
            };
            yield return new TestCase
            {
                String = "ab",
                Pattern = ".*",
                Result = true
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public string Pattern { get; set; }

            public bool Result { get; set; }
        }
    }
}