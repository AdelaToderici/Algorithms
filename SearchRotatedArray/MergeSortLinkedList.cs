using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class MergeSortLinkedList
    {
        public static Node SortList(Node root)
        {
            if (root == null) { return null; }

            if (root.next == null) { return root; }

            if (root.next.next == null)
            {
                if (root.next.value < root.value)
                {
                    var rootNext = root.next;
                    rootNext.next = root;
                    root.next = null;

                    return rootNext;
                }

                return root;
            }

            Node slow = root;
            Node fast = root;

            while(fast.next != null)
            {
                slow = slow.next;
                if (fast.next.next == null)
                {
                    fast = fast.next;
                    break;
                }
                fast = fast.next.next;
            }

            Node newSlow = slow.next;
            slow.next = null;

            Node left = SortList(root.next);
            Node right = SortList(newSlow);

            if (left == null && right != null)
            {
                return right;
            }
            if (left != null && right == null)
            {
                return left;
            }

            return MergeLinkedLists.Merge(left, right);
        }
    }
}
