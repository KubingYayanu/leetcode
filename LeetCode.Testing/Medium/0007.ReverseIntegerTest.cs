using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class ReverseIntegerTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Reverse_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new ReverseInteger();

            var result = sut.Reverse(testCase.Num);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Num = 0,
                Result = 0
            };
            yield return new TestCase
            {
                Num = 123,
                Result = 321
            };
            yield return new TestCase
            {
                Num = -123,
                Result = -321
            };
            yield return new TestCase
            {
                Num = 120,
                Result = 21
            };
            yield return new TestCase
            {
                Num = -2147483648,
                Result = 0
            };
            yield return new TestCase
            {
                Num = 1534236469,
                Result = 0
            };
        }

        public class TestCase
        {
            public int Num { get; set; }

            public int Result { get; set; }
        }
    }
}