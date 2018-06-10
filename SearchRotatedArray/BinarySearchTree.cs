using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class BinarySearchTree
    {
        public static bool IsBST(TreeNode root)
        {
            if (root == null)
            {
                throw new Exception("root is null."); // exception
            }

            if (root.left == null && root.right == null)
            {
                throw new Exception("root has no childs."); // exception
            }

            return Is_BST(root).Item1;
        }

        private static Tuple<bool, int, int> Is_BST(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                return Tuple.Create(true, node.value, node.value);
            }

            if (node.left != null && node.right == null)
            {
                Tuple<bool, int, int> leftT = Is_BST(node.left);

                return (leftT.Item1 == false || leftT.Item3 > node.value) ? Tuple.Create(false, 0, 0) : 
                    Tuple.Create(true, leftT.Item2, node.value);
            }

            if (node.left == null && node.right != null)
            {
                Tuple<bool, int, int> rightT = Is_BST(node.right);

                return (rightT.Item1 == false || rightT.Item3 < node.value) ? Tuple.Create(false, 0, 0) :
                    Tuple.Create(true, node.value, rightT.Item3);
            }

            Tuple<bool, int, int> left = Is_BST(node.left);
            Tuple<bool, int, int> right = Is_BST(node.right);

            if (left.Item1 == false || right.Item1 == false)
            {
                return Tuple.Create(false, 0, 0);
            }

            if (left.Item3 > node.value || node.value > right.Item2)
            {
                return Tuple.Create(false, 0, 0);
            }

            return Tuple.Create(true, left.Item2, right.Item3);
        } 
    }
}
