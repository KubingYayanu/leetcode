using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class DivideTwoIntegersTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Divide_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new DivideTwoIntegers();

            var result = sut.Divide(testCase.Dividend, testCase.Divisor);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Dividend = 10,
                Divisor = 3,
                Result = 3
            };
            yield return new TestCase
            {
                Dividend = 7,
                Divisor = -3,
                Result = -2
            };
            yield return new TestCase
            {
                Dividend = 2147483647,
                Divisor = 2,
                Result = 1073741823
            };
            yield return new TestCase
            {
                Dividend = -2147483648,
                Divisor = 2,
                Result = -1073741824
            };
        }

        public class TestCase
        {
            public int Dividend { get; set; }

            public int Divisor { get; set; }

            public int Result { get; set; }
        }
    }
}