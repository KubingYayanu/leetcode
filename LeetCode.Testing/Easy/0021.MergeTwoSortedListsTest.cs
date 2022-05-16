using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class MergeTwoSortedListsTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void MergeTwoLists_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new MergeTwoSortedLists();

            var result = sut.MergeTwoLists(testCase.List1, testCase.List2);
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
                List1 = new ListNode(1, new ListNode(2, new ListNode(4))),
                List2 = new ListNode(1, new ListNode(3, new ListNode(4))),
                Result = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))))
            };
            yield return new TestCase
            {
                List1 = null,
                List2 = null,
                Result = null
            };
            yield return new TestCase
            {
                List1 = null,
                List2 = new ListNode(0),
                Result = new ListNode(0)
            };
        }

        public class TestCase
        {
            public ListNode List1 { get; set; }

            public ListNode List2 { get; set; }

            public ListNode Result { get; set; }
        }
    }
}