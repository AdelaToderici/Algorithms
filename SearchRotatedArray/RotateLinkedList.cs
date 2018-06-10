using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class RotateLinkedList
    {
        public static Node RotateList(Node root, int n)
        {
            if (n == 0) { return root; }

            Node current = root;

            while (current.next != null)
            {
                current = current.next;
            }

            Node rotatedNode = root;

            for (int i = 0; i < n - 1; i++)
            {
                rotatedNode = rotatedNode.next;
            }

            Node newRoot = rotatedNode.next;
            rotatedNode.next = null;
            current.next = root;

            return newRoot;
        }
    }
}
