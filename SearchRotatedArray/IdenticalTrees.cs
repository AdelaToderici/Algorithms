using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(TreeNode left, TreeNode right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }

        public TreeNode()
        {

        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public class IdenticalTrees
    {
        public static bool FindIdentialTrees(TreeNode root1, TreeNode root2)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();

            q1.Enqueue(root1);
            q2.Enqueue(root2);

            while (q1.Count > 0)
            {
                if (q1.Count != q2.Count) { return false; }

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

        public static bool FindIdentialTrees2(TreeNode root1, TreeNode root2)
        {
            List<TreeNode> inorder1 = new List<TreeNode>();
            List<TreeNode> inorder2 = new List<TreeNode>();
            List<TreeNode> preorder1 = new List<TreeNode>();
            List<TreeNode> preorder2 = new List<TreeNode>();

            InorderTraversal(root1, inorder1);
            InorderTraversal(root2, inorder2);

            PreorderTraversal(root1, preorder1);
            PreorderTraversal(root2, preorder2);

            if (inorder1.Count != inorder2.Count) { return false; }

            for (int i = 0; i < inorder1.Count; i++)
            {
                if (inorder1[i].value != inorder2[i].value) { return false; } 
            }

            for (int i = 0; i < preorder1.Count; i++)
            {
                if (preorder1[i].value != preorder2[i].value) { return false; }
            }

            return true;
        }

        private static void InorderTraversal(TreeNode root, List<TreeNode> list)
        {
            if (root == null) { return; }
            InorderTraversal(root.left, list);
            list.Add(root);
            InorderTraversal(root.right, list);
        }

        private static void PreorderTraversal(TreeNode root, List<TreeNode> list)
        {
            if (root == null) { return; }
            list.Add(root);
            InorderTraversal(root.left, list);
            InorderTraversal(root.right, list);
        }
    }

}
