using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class ContainerWithMostWaterTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void MaxArea_WhenCalled_ReturnArea(TestCase testCase)
        {
            var sut = new ContainerWithMostWater();

            var result = sut.MaxArea(testCase.Array);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Array = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 },
                Result = 49
            };
            yield return new TestCase
            {
                Array = new[] { 1, 1 },
                Result = 1
            };
        }

        public class TestCase
        {
            public int[] Array { get; set; }

            public int Result { get; set; }
        }
    }
}