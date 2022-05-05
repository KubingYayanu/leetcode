using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void LengthOfLongestSubstring_WhenCalled_ReturnLength(TestCase testCase)
        {
            var sut = new LongestSubstringWithoutRepeatingCharacters();

            var result = sut.LengthOfLongestSubstring(testCase.String);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                String = "abcabcbb",
                Result = 3
            };
            yield return new TestCase
            {
                String = "bbbbb",
                Result = 1
            };
            yield return new TestCase
            {
                String = "pwwkew",
                Result = 3
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public int Result { get; set; }
        }
    }
}