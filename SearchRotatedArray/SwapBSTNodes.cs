using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class SwapBSTNodes
    {
        public static TreeNode SwapNodes(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            InorderTraversal(root, list);

            TreeNode swapNode = null;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i-1].value > list[i].value && swapNode != null)
                {
                    int temp = swapNode.value;
                    swapNode.value = list[i].value;
                    list[i].value = temp;
                }

                if (list[i - 1].value > list[i].value)
                {
                    swapNode = list[i - 1];
                }
            }

            return root;
        }

        private static void InorderTraversal(TreeNode node, List<TreeNode> list)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.left, list);
            list.Add(node);
            InorderTraversal(node.right, list);
        }
    }
}
