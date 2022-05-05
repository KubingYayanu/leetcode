namespace LeetCode.Library.Medium
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode();
            var tempNode = root;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var currentSum = 0;
                if (l1 != null)
                {
                    currentSum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    currentSum += l2.val;
                    l2 = l2.next;
                }

                currentSum += carry;
                carry = currentSum / 10;

                tempNode.next = new ListNode(currentSum % 10);
                tempNode = tempNode.next;
            }

            if (carry > 0)
            {
                tempNode.next = new ListNode(carry);
            }

            return root.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}