using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;
using static LeetCode.Library.Medium.RemoveNthNodeFromEndOfList;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class RemoveNthNodeFromEndOfListTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void RemoveNthFromEnd_WhenCalled_ReturnResult(TestCase testCase)
        {
            var sut = new RemoveNthNodeFromEndOfList();

            var result = sut.RemoveNthFromEnd(testCase.Head, testCase.Target);
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
                Head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                Target = 5,
                Result = new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))
            };
            yield return new TestCase
            {
                Head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                Target = 1,
                Result = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))))
            };
            yield return new TestCase
            {
                Head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                Target = 2,
                Result = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))))
            };
            yield return new TestCase
            {
                Head = new ListNode(1),
                Target = 1,
                Result = null
            };
        }

        public class TestCase
        {
            public ListNode Head { get; set; }

            public int Target { get; set; }

            public ListNode Result { get; set; }
        }
    }
}