using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class SwapNthNode
    {
        public static Node SwapNthNodeWithHead(Node root, int n)
        {
            int counter = 0;
            Node iterator = root;
            Node oldRoot = root;
            Node current = root;

            while (root.next != null)
            {
                if (counter == n)
                {
                    Node oldNext = root.next;
                    current.next = root;
                    root.next = iterator.next;
                    oldRoot = iterator;
                    oldRoot.next = oldNext;

                    return oldRoot;
                }
                counter++;
                current = iterator;
                iterator = iterator.next;
            }

            return root;
        }

        public static Node SwapNthNodeWithHead2(Node root, int n)
        {  
            Node oldRoot = root;
            Node current = root;

            for(int i = 0; i < n - 1; i++)
            {
                current = current.next;
            }

            var swappedNode = current.next;    
            current.next = oldRoot;
            var rootNext = oldRoot.next;
            oldRoot.next = swappedNode.next;
            swappedNode.next = rootNext;

            return swappedNode;
        }
    }
}
