using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class TreeMirror
    {
        public static void Mirror(TreeNode root)
        {
            if (root == null) { return; }

            if (root.left != null && root.right == null)
            {
                var tempL = root.left;
                root.left = null;
                root.right = tempL;

                Mirror(root.left);
            }

            if (root.left == null && root.right != null)
            {
                var tempR = root.right;
                root.right = null;
                root.left = tempR;

                Mirror(root.left);
            }

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            Mirror(root.left);
            Mirror(root.right);
        }
    }
}
