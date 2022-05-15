using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var index = 1;
            var map = new Dictionary<int, ListNode>();
            while (head != null)
            {
                map.Add(index, head);
                head = head.next;
                index++;
            }

            var targetIndex = index - n;
            var newNextIndex = targetIndex + 1;
            if (targetIndex == 1 && !map.ContainsKey(newNextIndex))
            {
                map[1] = null;
            }
            else if (targetIndex == 1 && map.ContainsKey(newNextIndex))
            {
                map[1] = map[newNextIndex];
            }
            else if (targetIndex == index - 1)
            {
                map[targetIndex - 1].next = null;
            }
            else if (!map.ContainsKey(newNextIndex))
            {
                map[targetIndex].next = null;
            }
            else
            {
                map[targetIndex - 1].next = map[newNextIndex];
            }

            return map[1];
        }

        public class ListNode
        {
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public int val { get; set; }

            public ListNode next { get; set; }
        }
    }
}