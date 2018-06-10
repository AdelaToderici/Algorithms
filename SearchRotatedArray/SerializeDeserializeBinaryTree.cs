using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class SerializeDeserializeBinaryTree
    {
        public static Tuple<List<int>, List<int>> SerializeTree(TreeNode root)
        {
            List<int> inorderList = new List<int>();
            List<int> preorderList = new List<int>();

            InorderTraversal(inorderList, root);
            PreorderTraversal(preorderList, root);

            return Tuple.Create(inorderList, preorderList);
        }

        public static TreeNode DeserializeList(List<int> inorderList, List<int> preorderList)
        {

            if (inorderList.Count == 0 || preorderList.Count == 0) { return null; }

            TreeNode root = new TreeNode();
            root.value = preorderList[0];

            var midd = inorderList.IndexOf(root.value);

            if (midd == 0 && inorderList.Count == 1) { return root; }

            var inorderLeft = inorderList.GetRange(0, midd);
            var inorderRight = inorderList.GetRange(midd + 1, inorderList.Count - midd - 1);

            var preorderLeft = preorderList.GetRange(1, midd);
            var preorderRight = preorderList.GetRange(midd + 1, inorderList.Count - midd - 1);

            TreeNode left = DeserializeList(inorderLeft, preorderLeft);
            TreeNode right = DeserializeList(inorderRight, preorderRight);

            root.left = left;
            root.right = right;

            return root;
        }

        private static void InorderTraversal(List<int> list, TreeNode node)
        {
            if (node == null) { return; }

            InorderTraversal(list, node.left);
            list.Add(node.value);
            InorderTraversal(list, node.right);
        }

        private static void PreorderTraversal(List<int> list, TreeNode node)
        {
            if (node == null) { return; }

            list.Add(node.value);
            PreorderTraversal(list, node.left);
            PreorderTraversal(list, node.right);
        }
    }
}
