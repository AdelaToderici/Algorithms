using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class LCA
    {
        public static TreeNode FindLCA(TreeNode root, TreeNode node1, TreeNode node2)
        { 
            if (root == null) { return null; }
            if (root == node1 || root == node2) { return root; }

            TreeNode left = FindLCA(root.left, node1, node2);
            TreeNode right = FindLCA(root.right, node1, node2);

            if (left != null && right != null) { return root; }
            if (left == null && right == null) { return null; }

            return (left != null) ? left : right;
        }
    }
}
