using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class ReversedKLinkedList
    {
        public static Node ReverseKElements(Node root, int k)
        {
            if (k == 0 || k == 1) { return root; }

            Node current = root.next;
            Node newRoot = current;
            Node oldRoot = root;

            for (int i = 1; i < k; i++)
            {
                Node lastNode = oldRoot;
                int j = 1;
                while (i != j)
                {
                    j++;
                    lastNode = lastNode.next;
                }

                newRoot = current;
                Node newNext = current.next;
                lastNode.next = newNext;

                newRoot.next = oldRoot;

                current = current.next.next;
                oldRoot = newRoot;
            }

            return newRoot;
        }
    }
}
