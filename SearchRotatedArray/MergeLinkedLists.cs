using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class MergeLinkedLists
    {
        public static Node Merge(Node root1, Node root2)
        {
            Node mergedList = root1;

            if (root1 == null && root2 != null)
            {
                return root2;
            }

            if (root1 != null && root2 == null)
            {
                return root1;
            }

            Node iterator1 = root1;
            Node iterator2 = root2;

            Node current1 = null;
            Node current2 = null;

            if (iterator1.next == null || iterator2.next == null)
            {
                if (iterator1.value < iterator2.value)
                {
                    current1 = iterator1;
                    iterator1 = iterator1.next;
                }
                else
                {
                    while (iterator2.value < iterator1.value)
                    {
                        current2 = iterator2;
                        iterator2 = iterator2.next;
                    }

                    current1.next = root2;
                    current2.next = iterator1;
                    iterator1.next = iterator2;
                }
            }

            while (iterator1.next != null || iterator2.next != null)
            {
                if (iterator1.value < iterator2.value)
                {
                    current1 = iterator1;
                    iterator1 = iterator1.next;
                }
                else
                {
                    while (iterator2.value < iterator1.value)
                    {
                        current2 = iterator2;
                        iterator2 = iterator2.next;
                    }

                    current1.next = root2;
                    current2.next = iterator1;
                    iterator1.next = iterator2;
                }
            }

            return root1;
        }
    }
}
