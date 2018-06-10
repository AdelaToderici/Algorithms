using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class VerticalTree
    {
        static Dictionary<TreeNode, int> dict = new Dictionary<TreeNode, int>();

        public static void PrintVerticalNodes(TreeNode root)
        {
            VisitNodes(root, 0);
            
            foreach (var value in dict.GroupBy(x => x.Value).ToDictionary(x=>x.Key, x=>x))
            {
                Console.WriteLine(String.Join(", ", value.Value));
            }
        }

        private static void VisitNodes(TreeNode node, int position)
        {
            if (node == null) { return; }

            VisitNodes(node.left, position - 1);
            VisitNodes(node.right, position + 1);

            dict.Add(node, position);
        }
    }
}
