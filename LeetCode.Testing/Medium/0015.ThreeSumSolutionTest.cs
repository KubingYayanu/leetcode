using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class ThreeSumSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void ThreeSum_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new ThreeSumSolution();

            var result = sut.ThreeSum(testCase.Nums);

            CollectionAssert.AreEquivalent(result, testCase.Result);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Nums = new[] { -1, 0, 1, 2, -1, -4 },
                Result = new List<IList<int>>
                {
                    new List<int> { -1, -1, 2 },
                    new List<int> { -1, 0, 1 }
                }
            };
            yield return new TestCase
            {
                Nums = new int[0],
                Result = new List<IList<int>>()
            };
            yield return new TestCase
            {
                Nums = new[] { 0 },
                Result = new List<IList<int>>()
            };
        }

        public class TestCase
        {
            public int[] Nums { get; set; }

            public IList<IList<int>> Result { get; set; }
        }
    }
}