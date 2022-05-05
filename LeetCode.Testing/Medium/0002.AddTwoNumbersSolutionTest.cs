using LeetCode.Library.Medium;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Medium
{
    [TestFixture]
    public class AddTwoNumbersSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void Run_WhenCalled_ReturnListNode(TestCase testCase)
        {
            var sub = new AddTwoNumbersSolution();

            var result = sub.AddTwoNumbers(testCase.L1, testCase.L2);
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
            //yield return new TestCase
            //{
            //    L1 = new ListNode(2, new ListNode(4, new ListNode(3))),
            //    L2 = new ListNode(5, new ListNode(6, new ListNode(4))),
            //    Result = new ListNode(7, new ListNode(0, new ListNode(8))),
            //};
            //yield return new TestCase
            //{
            //    L1 = new ListNode(),
            //    L2 = new ListNode(),
            //    Result = new ListNode(),
            //};
            yield return new TestCase
            {
                L1 = new ListNode(9),
                L2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))))),
                Result = new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1)))))))))))
            };
        }

        public class TestCase
        {
            public ListNode L1 { get; set; }

            public ListNode L2 { get; set; }

            public ListNode Result { get; set; }
        }
    }
}