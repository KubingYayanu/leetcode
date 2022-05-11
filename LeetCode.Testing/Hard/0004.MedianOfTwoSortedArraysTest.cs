using LeetCode.Library.Hard;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Hard
{
    [TestFixture]
    public class MedianOfTwoSortedArraysTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void FindMedianSortedArrays_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new MedianOfTwoSortedArrays();

            var result = sut.FindMedianSortedArrays(testCase.Nums1, testCase.Nums2);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Nums1 = new[] { 1, 3 },
                Nums2 = new[] { 2 },
                Result = 2
            };
            yield return new TestCase
            {
                Nums1 = new[] { 1, 2 },
                Nums2 = new[] { 3, 4 },
                Result = 2.5
            };
            yield return new TestCase
            {
                Nums1 = new int[0],
                Nums2 = new[] { 1 },
                Result = 1
            };
            yield return new TestCase
            {
                Nums1 = new[] { 1, 3 },
                Nums2 = new[] { 2, 7 },
                Result = 2.5
            };
        }

        public class TestCase
        {
            public int[] Nums1 { get; set; }

            public int[] Nums2 { get; set; }

            public double Result { get; set; }
        }
    }
}