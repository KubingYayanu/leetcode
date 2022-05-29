using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class SearchInRotatedSortedArrayTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Search_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new SearchInRotatedSortedArray();

            var result = sut.Search(testCase.Array, testCase.Target);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Array = new int[] { 4, 5, 6, 7, 0, 1, 2 },
                Target = 0,
                Result = 4
            };
            yield return new TestCase
            {
                Array = new int[] { 4, 5, 6, 7, 0, 1, 2 },
                Target = 3,
                Result = -1
            };
            yield return new TestCase
            {
                Array = new int[] { 1, 3 },
                Target = 3,
                Result = 1
            };
        }

        public class TestCase
        {
            public int[] Array { get; set; }

            public int Target { get; set; }

            public int Result { get; set; }
        }
    }
}