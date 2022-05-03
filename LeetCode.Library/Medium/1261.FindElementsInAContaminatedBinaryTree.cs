using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class FindElements
    {
        public HashSet<int> Set { get; set; } = new HashSet<int>();

        public FindElements(TreeNode root)
        {
            Recorver(root, 0);
        }

        private void Recorver(TreeNode node, int value)
        {
            if (node == null)
            {
                return;
            }

            Set.Add(value);
            Recorver(node.Left, 2 * value + 1);
            Recorver(node.Right, 2 * value + 2);
        }

        public bool Find(int target)
        {
            return Set.Contains(target);
        }
    }

    public class TreeNode
    {
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }

        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}