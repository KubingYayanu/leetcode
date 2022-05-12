using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class LongestCommonPrefixSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void LongestCommonPrefix_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new LongestCommonPrefixSolution();

            var result = sut.LongestCommonPrefix(testCase.Array);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Array = new[] { "flower", "flow", "flight" },
                Result = "fl"
            };
            yield return new TestCase
            {
                Array = new[] { "dog", "racecar", "car" },
                Result = ""
            };
            yield return new TestCase
            {
                Array = new[] { "" },
                Result = ""
            };
            yield return new TestCase
            {
                Array = new[] { "a" },
                Result = "a"
            };
            yield return new TestCase
            {
                Array = new[] { "a", "b" },
                Result = ""
            };
            yield return new TestCase
            {
                Array = new[] { "ab", "a" },
                Result = "a"
            };
        }

        public class TestCase
        {
            public string[] Array { get; set; }

            public string Result { get; set; }
        }
    }
}