using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class PalindromeNumberTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void IsPalindrome_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new PalindromeNumber();

            var result = sut.IsPalindrome(testCase.Num);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Num = 121,
                Result = true
            };
            yield return new TestCase
            {
                Num = -121,
                Result = false
            };
            yield return new TestCase
            {
                Num = 10,
                Result = false
            };
            yield return new TestCase
            {
                Num = 1001,
                Result = true
            };
        }

        public class TestCase
        {
            public int Num { get; set; }

            public bool Result { get; set; }
        }
    }
}