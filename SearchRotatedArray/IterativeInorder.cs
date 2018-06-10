using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class IterativeInorder
    {
        public static void Inorder(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            HashSet<TreeNode> set = new HashSet<TreeNode>();

            stack.Push(root);
            set.Add(root);

            TreeNode node = stack.Peek();

            while (stack.Count > 0)
            {
                if (node.left != null && !set.Contains(node.left))
                {
                    while (node.left != null)
                    {
                        node = node.left;
                        stack.Push(node);
                        set.Add(node);
                    }

                    if (node.left == null && node.right == null)
                    {
                        PopNode(stack, node);
                    } 
                }

                node = stack.Peek();

                if (node.right != null && !set.Contains(node.right))
                {
                    PopNode(stack, node);

                    node = node.right;
                    stack.Push(node);
                    set.Add(node);
                }
                else
                {
                    PopNode(stack, node);
                }
            }
        }

        private static void PopNode(Stack<TreeNode> stack, TreeNode node)
        {
            stack.Pop();
            Console.Write("{0} ", node.value);
        }

    }
}
