using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class LevelOrderTraversal
    {
        public static List<Tuple<int, int>> Iterate(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            Tuple<int, int> t = Tuple.Create(root.value, 0);
            list.Add(t);

            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();

                if (node.left != null)
                {
                    q.Enqueue(node.left);

                    int index = list.First(m => m.Item1 == node.value).Item2;
                    Tuple<int, int> tuple1 = Tuple.Create(node.left.value, index + 1);
                    list.Add(tuple1);
                }

                if (node.right != null)
                { 
                    q.Enqueue(node.right);

                    int index = list.First(m => m.Item1 == node.value).Item2;
                    Tuple<int, int> tuple2 = Tuple.Create(node.right.value, index + 1);
                    list.Add(tuple2);
                }
            }

            for (int i = 0; i <= list.Max(x=>x.Item2); i++)
            {
                Console.WriteLine(String.Join(" ", list.Where(x => x.Item2 == i).Select(x => x.Item1).ToArray()));
            }

            return list;
        }
    }
}
