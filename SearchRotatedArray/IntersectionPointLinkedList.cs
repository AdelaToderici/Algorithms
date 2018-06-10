using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class IntersectionPointLinkedList
    {
        public static Node FindIntersection(Node root1, Node root2)
        {
            HashSet<Node> set = new HashSet<Node>();
            set.Add(root1);
            Node iterator1 = root1.next;
            Node iterator2 = root2;

            while (iterator1.next != null || iterator2.next != null)
            {
                if (set.Contains(iterator2))
                {
                    return iterator2;
                }
                if (iterator1.next != null)
                {
                    iterator1 = iterator1.next;
                    set.Add(iterator1);
                }
                iterator2 = iterator2.next;
            }

            return null;
        }

        public static Node FindIntersectionRecursively(Node root1, Node root2)
        {
            if (root1 == null || root2 == null)
            {
                return null;
            }

            if (root1 == root2)
            {
                return root1;
            }


            var first = FindIntersectionRecursively(root1.next, root2);
            var second = FindIntersectionRecursively(root1, root2.next);

            if (first == null)
                return second;

            return first;
        }
    }
}
