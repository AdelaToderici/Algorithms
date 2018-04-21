using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class InsertionSortLinkedList
    {
        public static Node SortList(Node root)
        {
            if (root.next == null)
                return root;

            Node current = root.next;
            var max = int.MinValue;

            while (current != null)
            {
                if (max < current.value)
                    max = current.value;

                var iterator = root; 

                if(iterator.value>current.value)
                {
                    var swappedNode = current;
                    current = current.next;   
                    swappedNode.next = iterator;
                    root= swappedNode;
                    continue;
                }

                while (iterator.next.value < current.value && iterator.next!=current)
                { 
                    iterator = iterator.next;
                } 

                var swappedNode2 = current;
                current = current.next; 

                    swappedNode2.next = iterator.next;
                    iterator.next = swappedNode2;
            }

            current = root;

            while(current.value!=max)
            {
                current = current.next;
            }

            current.next = null;


            return root;
        }
    }
}
