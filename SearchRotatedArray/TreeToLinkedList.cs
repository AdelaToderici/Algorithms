using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class NodeX
    {
        public NodeX next;
        public NodeX prev;
        public int value;

        public NodeX(NodeX next, NodeX prev, int value)
        {
            this.next = next;
            this.prev = prev;
            this.value = value;
        }

        public NodeX()
        {

        }
    }

    class TreeToLinkedList
    {

        public static Tuple<NodeX, NodeX> ConvertTreeToDoubleLinkedList(TreeNode node)
        {
            if (node.left == null && node.right == null) {
                NodeX node1 = new NodeX(null, null, node.value);
                return Tuple.Create(node1, node1);
            }

            if (node.left != null && node.right == null)
            {
                var tuple = ConvertTreeToDoubleLinkedList(node.left);

                NodeX root = new NodeX(null, null, node.value);
                root.prev = tuple.Item2;
                tuple.Item2.next = root;

                return Tuple.Create(tuple.Item1, root);
            }

            if (node.left == null && node.right != null)
            {
                var tuple = ConvertTreeToDoubleLinkedList(node.right);

                NodeX root = new NodeX(null, null, node.value);
                root.next = tuple.Item1;
                tuple.Item1.prev = root;

                return Tuple.Create(root, tuple.Item2);
            }

            var leftTuple = ConvertTreeToDoubleLinkedList(node.left);
            var rightTuple = ConvertTreeToDoubleLinkedList(node.right);

            NodeX rootX = new NodeX(rightTuple.Item1, leftTuple.Item2, node.value);
            rightTuple.Item1.prev = rootX;
            leftTuple.Item2.next = rootX;

            return Tuple.Create(leftTuple.Item1, rightTuple.Item2);
        }

    }
}
