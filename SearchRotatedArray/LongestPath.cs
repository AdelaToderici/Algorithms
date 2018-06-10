using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class LongestPath
    {
        public static int FindLongestPath(TreeNode node)
        {
            if (node == null)
            {
                throw new Exception("Root is null");
            }

            if (node.left == null && node.right == null)
            {
                return 1;
            }

            if (node.left != null && node.right == null)
            {
                return Math.Max(FindLongestPath(node.left), FindHeight(node.left) + 1);
            }

            if (node.left == null && node.right != null)
            {
                return Math.Max(FindLongestPath(node.right), FindHeight(node.right) + 1); 
            }

            int left = FindLongestPath(node.left);
            int right = FindLongestPath(node.right);
            int sum = FindHeight(node.left) + FindHeight(node.right) + 1;

            return Math.Max(left, Math.Max(right, sum));
        }

        private static int FindHeight(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                return 1;
            }

            if (node.left != null && node.right == null)
            {
                return FindHeight(node.left) + 1;
            }

            if (node.left == null && node.right != null)
            {
                return FindHeight(node.right) + 1;
            }

            return Math.Max(FindHeight(node.left), FindHeight(node.right)) + 1;
        }
    }
}
