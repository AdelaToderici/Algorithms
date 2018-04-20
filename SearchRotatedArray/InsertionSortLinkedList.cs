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
            Node current = root;

            while (current.next != null)
            {
                if (current.next.value < current.value)
                {
                    Node small = current.next;

                    current.next = current.next.next;

                    if (small.value < root.value)
                    {
                        Node oldRoot = root;
                        root = small;
                        root.next = oldRoot;
                    }
                    else
                    {
                        Node newCurrent = root;
                        Node oldRoot = root;

                        while (small.value > newCurrent.value)
                        {
                            Node oldNext = oldRoot.next;
                            small.next = oldNext;
                            oldRoot.next = small;

                            newCurrent = newCurrent.next;
                        }
                    }
                }
                else
                {
                    current = current.next;
                }
            }

            return root;
        }
    }
}
