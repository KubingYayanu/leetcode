using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class LetterCombinationsOfAPhoneNumberTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void LetterCombinations_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new LetterCombinationsOfAPhoneNumber();

            var result = sut.LetterCombinations(testCase.String);

            CollectionAssert.AreEquivalent(result, testCase.Result);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                String = "23",
                Result = new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
            };
            yield return new TestCase
            {
                String = "",
                Result = new string[0]
            };
            yield return new TestCase
            {
                String = "2",
                Result = new[] { "a", "b", "c" }
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public string[] Result { get; set; }
        }
    }
}