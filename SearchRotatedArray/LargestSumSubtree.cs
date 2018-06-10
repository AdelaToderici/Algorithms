using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class LargestSumSubtree
    {
        static int globalMax = 0;
        static TreeNode resultNode;

        public static TreeNode FindSum(TreeNode root)
        {
            Sum(root);
            return resultNode;
        }

        private static int Sum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.left == null && node.right == null)
            {
                return node.value;
            }

            if (node.left != null && node.right == null)
            {
                return Sum(node.left) + node.left.value;
            }

            if (node.left == null && node.right != null)
            {
                return Sum(node.right) + node.right.value;
            }

            int left = Sum(node.left);
            int right = Sum(node.right);

            int max = Math.Max(left, right);
            if (globalMax < max)
            {
                globalMax = max;
                resultNode = (left > right) ? node.left : node.right;
            }

            return left + right + node.value;
        }
    }
}
