using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class TreeFromArray
    {
        public static TreeNode ConvertPreorderArrayToTree(List<Tuple<int, string>> list)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            for (int i = list.Count - 1; i > -1; i--)
            {

                if (list[i].Item2 == "L")
                {
                    stack.Push(new TreeNode(null, null, list[i].Item1));
                }
                else
                {
                    TreeNode leftChild = stack.Pop();
                    TreeNode rightChild = stack.Pop();
                    TreeNode node = new TreeNode(leftChild, rightChild, list[i].Item1);
                    stack.Push(node);
                }

            }

            TreeNode root = stack.Pop();

            return root;
        }
    }
}
