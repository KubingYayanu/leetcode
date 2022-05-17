using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class GenerateParenthesesSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void GenerateParenthesis_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new GenerateParenthesesSolution();

            var result = sut.GenerateParenthesis(testCase.Count);

            CollectionAssert.AreEquivalent(result, testCase.Result);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Count = 3,
                Result = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" }
            };
            yield return new TestCase
            {
                Count = 2,
                Result = new List<string> { "()()", "(())" }
            };
            yield return new TestCase
            {
                Count = 1,
                Result = new List<string> { "()" }
            };
        }

        public class TestCase
        {
            public int Count { get; set; }

            public IList<string> Result { get; set; }
        }
    }
}