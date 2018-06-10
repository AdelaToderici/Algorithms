using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class BTRightSideView
    {
        public static void FetchRightSideNodes(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(new TreeNode(null, null, int.MaxValue));

            while (q.Count > 0)
            {
                while (q.Peek().value != int.MaxValue)
                {
                    TreeNode node = q.Dequeue();

                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }

                    if (q.Peek().value == int.MaxValue)
                    {
                        Console.Write(node.value + " ");
                        break;
                    }
                }

                q.Dequeue();
                if (q.Count == 0) { break; }

                q.Enqueue(new TreeNode(null, null, int.MaxValue));

            }
        }
    }
}
