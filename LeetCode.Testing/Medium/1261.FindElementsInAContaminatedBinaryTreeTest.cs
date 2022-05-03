using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class FindElementsInAContaminatedBinaryTreeTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Find_WhenCalled_ReturnBoolean(TestCase testCase)
        {
            var sub = new FindElements(testCase.Init);

            var result = sub.Find(testCase.Target);

            Assert.That(testCase.Result, Is.EqualTo(result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Init = new TreeNode(-1, null, new TreeNode(-1)),
                Target = 1,
                Result = false
            };
            yield return new TestCase
            {
                Init = new TreeNode(-1, null, new TreeNode(-1)),
                Target = 2,
                Result = true
            };
        }

        public class TestCase
        {
            public TreeNode Init { get; set; }

            public int Target { get; set; }

            public bool Result { get; set; }
        }
    }
}