using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class StringToIntegerAtoiTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void MyAtoi_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new StringToIntegerAtoi();

            var result = sut.MyAtoi(testCase.String);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            //yield return new TestCase
            //{
            //    String = "   -42",
            //    Result = -42
            //};
            //yield return new TestCase
            //{
            //    String = "4193 with words",
            //    Result = 4193
            //};
            //yield return new TestCase
            //{
            //    String = "+1",
            //    Result = 1
            //};
            //yield return new TestCase
            //{
            //    String = "+-12",
            //    Result = 0
            //};
            //yield return new TestCase
            //{
            //    String = "00000-42a1234",
            //    Result = 0
            //};
            yield return new TestCase
            {
                String = "  -0012a42",
                Result = -12
            };
            yield return new TestCase
            {
                String = " b11228552307",
                Result = 0
            };
        }

        public class TestCase
        {
            public string String { get; set; }

            public int Result { get; set; }
        }
    }
}