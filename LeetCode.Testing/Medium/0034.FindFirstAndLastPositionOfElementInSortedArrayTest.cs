using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class FindFirstAndLastPositionOfElementInSortedArrayTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void SearchRange_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new FindFirstAndLastPositionOfElementInSortedArray();

            var result = sut.SearchRange(testCase.Array, testCase.Target);

            CollectionAssert.AreEquivalent(result, testCase.Result);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Array = new int[] { 5, 7, 7, 8, 8, 10 },
                Target = 8,
                Result = new int[] { 3, 4 }
            };
            yield return new TestCase
            {
                Array = new int[] { 5, 7, 7, 8, 8, 10 },
                Target = 6,
                Result = new int[] { -1, -1 }
            };
            yield return new TestCase
            {
                Array = new int[0],
                Target = 0,
                Result = new int[] { -1, -1 }
            };
        }

        public class TestCase
        {
            public int[] Array { get; set; }

            public int Target { get; set; }

            public int[] Result { get; set; }
        }
    }
}