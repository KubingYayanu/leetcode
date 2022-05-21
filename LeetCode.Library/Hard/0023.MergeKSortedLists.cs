namespace LeetCode.Library.Hard
{
    public class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode root = null;
            ListNode last = null;
            var stop = false;
            while (!stop)
            {
                stop = true;
                var minValueIndex = 0;
                var minValue = double.PositiveInfinity;
                for (int i = 0; i < lists.Length; i++)
                {
                    var list = lists[i];
                    if (list != null)
                    {
                        stop = false;
                        var value = list.val;
                        if (value < minValue)
                        {
                            minValue = value;
                            minValueIndex = i;
                        }
                    }
                }

                if (stop)
                {
                    return root;
                }

                lists[minValueIndex] = lists[minValueIndex].next;
                if (root == null)
                {
                    root = new ListNode((int)minValue);
                    last = root;
                }
                else
                {
                    last.next = new ListNode((int)minValue);
                    last = last.next;
                }
            }

            return root;
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