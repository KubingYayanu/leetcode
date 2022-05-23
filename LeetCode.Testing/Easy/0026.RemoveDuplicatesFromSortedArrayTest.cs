using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void RemoveDuplicates_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var result = sut.RemoveDuplicates(testCase.Array);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Array = new[] { 1, 1, 1, 1 },
                Result = 1
            };
            yield return new TestCase
            {
                Array = new[] { 1, 1, 1 },
                Result = 1
            };
            yield return new TestCase
            {
                Array = new[] { 1, 1 },
                Result = 1
            };
            yield return new TestCase
            {
                Array = new[] { 10, 20, 30 },
                Result = 3
            };
            yield return new TestCase
            {
                Array = new[] { 1, 1, 2 },
                Result = 2
            };
            yield return new TestCase
            {
                Array = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
                Result = 5
            };
        }

        public class TestCase
        {
            public int[] Array { get; set; }

            public int Result { get; set; }
        }
    }
}