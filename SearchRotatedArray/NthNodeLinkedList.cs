using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class NthNodeLinkedList
    {
        public static Node FindNthLastNode(Node root, int k)
        {
            int counter = 0;
            Node iterator = root;
            while (iterator.next != null)
            {
                counter++;
                iterator = iterator.next;
            }

            if (counter < k) { return null; }

            if (counter == k) { return root; }

            if (k == 0) { return iterator; }

            iterator = root;
            int nth = counter - k;
            counter = 0;

            while (iterator.next != null)
            {
                if (counter == nth)
                {
                    return iterator;
                }
                iterator = iterator.next;
                counter++;
            }

            return null;
        }
    }
}
