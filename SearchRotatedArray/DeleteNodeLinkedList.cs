using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
     public class DeleteNodeLinkedList
    {
        public static Node DeleteNodeForGivenKey(Node root, int key)
        {
            Node current = root;
            int count = 0;

            while(current.next != null)
            {
                if (count + 1 == key) {
                    var start = current;
                    current.next = current.next.next;
                    start.next = current.next;
                    break;
                }
                else
                {
                    count++;
                    current = current.next;
                }
            }

            return root;
        }
    }
}
