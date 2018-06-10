using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class MaxLevelCountBT
    {
        public static int FindMaxLevel(TreeNode root)
        {
            if (root == null) { return 0; }

            int max = 0; int currMax = 0;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                q.Enqueue(new TreeNode(null, null, int.MinValue));

                while (q.Peek().value != int.MinValue)
                {
                    TreeNode node = q.Dequeue();
                    currMax++;
                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }

                q.Dequeue();

                if (currMax > max)
                {
                    max = currMax;
                    currMax = 0;
                }
            }

            return max;
        }
    }
}
