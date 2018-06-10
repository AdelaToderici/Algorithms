using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class PathSum
    {
        public static bool PathExists(TreeNode node, int sum)
        {
            if (node.left != null && PathExists(node.left, sum)) { return true; }
            if (node.right != null && PathExists(node.right, sum)) { return true; }

            for (int i = 0; i < sum - node.value; i++)
            {
                if (SumExists(node.left, i) && SumExists(node.right, sum - node.value - i))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool SumExists(TreeNode root, int sum)
        {
            return Sum(root, 0, sum);
        }

        private static bool Sum(TreeNode node, int currentSum, int sum)
        {
            if (node == null) { return false; }

            if (node.value == sum || node.value + currentSum == sum) { return true; }

            else if (node.left != null && node.right == null)
            {
                return Sum(node.left, node.value + currentSum, sum);
            }

            else if (node.left == null && node.right != null)
            {
                return Sum(node.right, node.value + currentSum, sum);
            }

            return Sum(node.left, node.value + currentSum, sum) || Sum(node.right, node.value + currentSum, sum);
        }
    }
}
