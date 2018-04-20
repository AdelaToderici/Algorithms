using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/210002/preview
    public class MaxSlidingWindow
    {
        public void FindMaxElementInWindow(int[] A, int k)
        {
            CustomHeap2<int> heap = new CustomHeap2<int>();

            for (int i = 0; i < k; i++)
            {
                heap.ValueToIndex[A[i]] = i;
                heap.Insert(A[i]);
            }
            Console.Write(heap.Peek() + " ");
            for (int i = 0; i < A.Length - k; i++)
            {
                heap.UpdateValue(A[i], A[i + k]);
                Console.Write(heap.Peek() + " ");
            }
        }
    }
}
