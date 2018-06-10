using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class SubtreeInTree
    {
        public static bool IsSubtree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null) { return false; }

            TreeNode commonRoot = FindCommonRootIfExists(root1, root2);

            if (commonRoot != null)
            {
                return IsSameSubtree(commonRoot, root2);
            }

            return false;
        }

        private static TreeNode FindCommonRootIfExists(TreeNode root1, TreeNode root2)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            q1.Enqueue(root1);

            while(q1.Count > 0)
            {
                TreeNode node1 = q1.Dequeue();

                if (node1.value == root2.value) { return node1; }

                if (node1.left != null) { q1.Enqueue(node1.left); }
                if (node1.right != null) { q1.Enqueue(node1.right); }
            }

            return null;
        }

        private static bool IsSameSubtree(TreeNode root1, TreeNode root2)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();

            q1.Enqueue(root1);
            q2.Enqueue(root2);

            while(q2.Count > 0)
            {
                TreeNode node1 = q1.Dequeue();
                TreeNode node2 = q2.Dequeue();

                if (node1.value != node2.value) { return false; }

                if (node1.left != null) { q1.Enqueue(node1.left); }
                if (node1.right != null) { q1.Enqueue(node1.right); }

                if (node2.left != null) { q2.Enqueue(node2.left); }
                if (node2.right != null) { q2.Enqueue(node2.right); }
            }

            return true;
        }
    }
}
