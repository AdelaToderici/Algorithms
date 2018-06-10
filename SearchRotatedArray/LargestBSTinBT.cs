using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class LargestBSTinBT
    {
        public static int FindLargestBST(TreeNode root)
        {
            if (root == null) { return 0; }

            int[] result = FindBST(root);

            return result[1];
        }

        private static int[] FindBST(TreeNode node)
        {

            if (node.left == null && node.right == null)
            {
                int[] result = new int[] { 1, 1, node.value, node.value };

                return result;
            }

            if (node.left != null && node.right == null)
            {
                if (FindBST(node.left)[0] == 1)
                {
                    if (node.value > FindBST(node.left)[3])
                    {
                        int[] result1 = new int[] { 1,
                        FindBST(node.left)[1] + 1,
                        Math.Min(node.value, FindBST(node.left)[2]),
                        Math.Max(node.value, FindBST(node.left)[3]) };

                        return result1;
                    }
                }

                int[] result = new int[] { 0, 1, 0, 0 };

                return result;
            }

            else if (node.left == null && node.right != null)
            {
                if (FindBST(node.right)[0] == 1)
                {
                    if (node.value < FindBST(node.right)[2])
                    {
                        int[] result1 = new int[] { 1,
                        FindBST(node.right)[1] + 1,
                        Math.Min(node.value, FindBST(node.right)[2]),
                        Math.Max(node.value, FindBST(node.right)[3]) };

                        return result1;
                    }
                }
                int[] result = new int[] { 0, 1, 0, 0 };

                return result;
            }

            else
            {
                if (FindBST(node.left)[0] == 1 && FindBST(node.right)[0] == 1)
                {
                    if (node.value < FindBST(node.right)[2] && node.value > FindBST(node.left)[3])
                    {
                        int[] result1 = new int[] { 1,
                        FindBST(node.left)[1] + FindBST(node.right)[1] + 1,
                        Math.Min(node.value, FindBST(node.left)[2]),
                        Math.Max(node.value, FindBST(node.right)[3]) };

                        return result1;
                    }
                }

                int[] result = new int[] { 1,
                Math.Max(FindBST(node.left)[1], FindBST(node.right)[1]),
                0,
                0 };

                return result;

            }
        }
    }
}
