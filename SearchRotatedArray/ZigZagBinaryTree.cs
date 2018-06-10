using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class ZigZagBinaryTree
    {
        public static void ZigZag(TreeNode root)
        {
            int levelCount = 0;

            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            stack1.Push(root);

            while(stack1.Count > 0 || stack2.Count > 0)
            {
                levelCount++;

                if (levelCount % 2 == 0)
                {
                    while (stack2.Count > 0)
                    {
                        TreeNode node = stack2.Pop();
                        Console.Write(node.value + " ");
                        if (node.right != null) { stack1.Push(node.right); }
                        if (node.left != null) { stack1.Push(node.left); }
                    }
                }
                else
                {
                    while (stack1.Count > 0)
                    {
                        TreeNode node = stack1.Pop();
                        Console.Write(node.value + " ");
                        if (node.left != null) { stack2.Push(node.left); }
                        if (node.right != null) { stack2.Push(node.right); }
                    }
                }
            }
        }
    }
}
