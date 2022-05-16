namespace LeetCode.Library.Easy
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode root = null;
            ListNode last = null;
            while (list1 != null || list2 != null)
            {
                var a = double.PositiveInfinity;
                var b = double.PositiveInfinity;
                if (list1 != null)
                {
                    a = list1.val;
                }
                if (list2 != null)
                {
                    b = list2.val;
                }

                if (a > b)
                {
                    var temp = b;
                    b = a;
                    a = temp;
                    list2 = list2.next;
                }
                else
                {
                    list1 = list1.next;
                }

                if (root == null)
                {
                    root = new ListNode((int)a);
                    last = root;
                }
                else
                {
                    last.next = new ListNode((int)a);
                    last = last.next;
                }
            }

            return root;
        }
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