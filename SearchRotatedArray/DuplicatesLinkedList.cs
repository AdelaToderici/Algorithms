using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class DuplicatesLinkedList
    {
        public static Node RemoveDuplicates(Node root)
        {
            HashSet<int> set = new HashSet<int>();
            var current = root;
            set.Add(root.value);

            while(current.next != null)
            {
                if (set.Contains(current.next.value))
                {
                    if(current.next.next==null)
                    {
                        current.next = null;
                        return root;
                    }

                    var start = current;
                    current = current.next;
                    
                    while (current.value == start.next.value)
                    {
                        current = current.next;
                    }

                    start.next = current;
                }
                else
                {
                    set.Add(current.next.value);
                    current = current.next;
                }
            }

            return root;
        }
    }
}
