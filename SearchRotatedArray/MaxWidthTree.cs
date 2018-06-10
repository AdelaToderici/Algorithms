using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class MaxWidthTree
    {
        public static int FindMaxWidth(TreeNode root)
        {
            if (root == null) { return -1; }

            int max = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(new TreeNode(null, null, int.MaxValue));

            while (q.Any(x => x != null && x.value != int.MaxValue))
            {
                while (q.Any(x => x != null && x.value != int.MaxValue))
                {
                    if (q.Peek() == null)
                    {
                        q.Enqueue(null);
                        q.Enqueue(null);
                        q.Dequeue();
                        continue;
                    }

                    if (q.Peek().value == int.MaxValue)
                    {
                        break;
                    }

                    TreeNode node = q.Dequeue();
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);

                }
                q.Dequeue();


                var first = q.FirstOrDefault(x => x != null);

                if (first == null) { break; }

                var last = q.Last(x => x != null);
                var array = q.ToList();
                int levelMax = array.IndexOf(last) - array.IndexOf(first) + 1;

                if (levelMax > max)
                {
                    max = levelMax;
                }

                q.Enqueue(new TreeNode(null, null, int.MaxValue));
            }

            return max;
        }
    }
}
