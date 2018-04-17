using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class Node
    {
        public Node next;
        public int value;

        public Node(Node next, int value)
        {
            this.next = next;
            this.value = value;
        }
    }

    class ReversedLinkedList
    {
        public static Node ReverseASinglyLinkedList(Node root)
        {
            Node previous = root;
            Node current = root.next;
            root.next = null;

            while (current != null)
            {
                root = current;
                current = current.next;
                root.next = previous;
                previous = root;
            }

            return root;
        }

        public static Node ReverseLinkListRecursively(Node root)
        {
            if (root.next == null)
            {
                return root;
            }          
           
            Node newRoot = ReverseLinkListRecursively(root.next);
            root.next.next = root;
            root.next = null;
            return newRoot;
        }
    }
}
