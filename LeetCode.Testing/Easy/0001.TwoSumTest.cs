using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Run_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new TwoSum();

            var indexes = sut.Run(testCase.Nums, testCase.Target);

            CollectionAssert.AreEquivalent(indexes, testCase.Result);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Nums = new[] { 1, 2, 3 },
                Target = 3,
                Result = new[] { 0, 1 }
            };
            yield return new TestCase
            {
                Nums = new int[] { 2, 7, 11, 15 },
                Target = 9,
                Result = new[] { 0, 1 }
            };
            yield return new TestCase
            {
                Nums = new int[] { 3, 2, 4 },
                Target = 6,
                Result = new[] { 1, 2 }
            };
            yield return new TestCase
            {
                Nums = new int[] { 2, 5, 5, 11 },
                Target = 10,
                Result = new[] { 1, 2 }
            };
        }

        public class TestCase
        {
            public int[] Nums { get; set; }

            public int Target { get; set; }

            public int[] Result { get; set; }
        }
    }
}