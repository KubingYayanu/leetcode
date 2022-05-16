using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class ValidParenthesesTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void IsValid_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new ValidParentheses();

            var result = sut.IsValid(testCase.String);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                String = "(){}}{",
                Result = false
            };
            yield return new TestCase
            {
                String = "{[]}",
                Result = true
            };
            yield return new TestCase
            {
                String = "()",
                Result = true
            };
            yield return new TestCase
            {
                String = "([]){}",
                Result = true
            };
            yield return new TestCase
            {
                String = "()[]{}",
                Result = true
            };
            yield return new TestCase
            {
                String = "(]",
                Result = false
            };
            yield return new TestCase
            {
                String = "",
                Result = false
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public bool Result { get; set; }
        }
    }
}