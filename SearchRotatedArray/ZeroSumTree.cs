using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class ZeroSumTree
    {
        public static int DeleteZeroSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null) {
                return root.value;
            }

            if (root.left != null && root.right == null) {
                return DeleteZeroSum(root.left) + root.value;
            }

            if (root.left == null && root.right != null) {
                return DeleteZeroSum(root.right) + root.value;
            }

            if (DeleteZeroSum(root.left) == 0) { root.left = null; }
            if (DeleteZeroSum(root.right) == 0) { root.right = null; }

            return DeleteZeroSum(root.left) + DeleteZeroSum(root.right) + root.value;
        }
    }
}
