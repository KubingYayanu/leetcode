using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class LongestPalindromeSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void LongestPalindrome_WhenCalled_ReturnSubstring(TestCase testCase)
        {
            var sut = new LongestPalindromeSolution();

            var result = sut.LongestPalindrome(testCase.String);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                String = "babad",
                Result = "bab"
            };
            yield return new TestCase
            {
                String = "cbbd",
                Result = "bb"
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public string Result { get; set; }
        }
    }
}