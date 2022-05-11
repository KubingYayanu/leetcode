using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class RomanToIntegerTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void RomanToInt_WhenCalled_ReturnSum(TestCase testCase)
        {
            var sut = new RomanToInteger();

            var result = sut.RomanToInt(testCase.String);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            //yield return new TestCase
            //{
            //    String = "III",
            //    Result = 3
            //};
            //yield return new TestCase
            //{
            //    String = "LVIII",
            //    Result = 58
            //};
            yield return new TestCase
            {
                String = "MCMXCIV",
                Result = 1994
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public int Result { get; set; }
        }
    }
}