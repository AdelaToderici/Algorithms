using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class PathSumRL
    {
        public static bool PathSumExists(TreeNode root, int sum)
        {
            return Sum(root, sum);
        }

        private static bool Sum(TreeNode node, int sum)
        {
            if (node == null) { return false; }

            if (node.value == sum && node.left == null && node.right == null)
            {
                return true;
            }

            return Sum(node.left, sum - node.value) || Sum(node.right, sum - node.value);
        }
    }
}
