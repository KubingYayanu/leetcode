using LeetCode.Library.Hard;
using NUnit.Framework;
using System.Collections.Generic;
using static LeetCode.Library.Hard.MergeKSortedLists;

namespace LeetCode.Testing.Hard
{
    [TestFixture]
    public class MergeKSortedListsTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void MergeKLists_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new MergeKSortedLists();

            var result = sut.MergeKLists(testCase.Nodes);
            var areIdentical = AreIdentical(result, testCase.Result);

            Assert.That(areIdentical, Is.True);
        }

        public bool AreIdentical(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            return (l1 == null && l2 == null);
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Nodes = new[]
                {
                    new ListNode(1, new ListNode(4, new ListNode(5))),
                    new ListNode(1, new ListNode(3, new ListNode(4))),
                    new ListNode(2, new ListNode(6))
                },
                Result = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))))
            };
        }

        public class TestCase
        {
            public ListNode[] Nodes { get; set; }

            public ListNode Result { get; set; }
        }
    }
}