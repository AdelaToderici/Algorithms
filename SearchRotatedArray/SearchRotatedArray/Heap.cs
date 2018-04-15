using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/100002/preview
    public class CustomHeap2<T> where T : IComparable
    {
        private List<T> data = new List<T>();
        public Dictionary<T, int> ValueToIndex = new Dictionary<T, int>();

        public void UpdateValue(T oldValue, T newValue)
        {
            if (oldValue.Equals(newValue))
                return;

            bool heapifyUp = newValue.CompareTo(oldValue)<0 ? true : false;
            ValueToIndex[newValue] = ValueToIndex[oldValue];
            data[ValueToIndex[oldValue]] = newValue;
            ValueToIndex.Remove(oldValue);

            if (newValue.CompareTo(oldValue) < 0)
            {
                HeapifyUp(ValueToIndex[newValue]);
            }
            else
            {
                HeapifyDown(ValueToIndex[newValue]);
            }
        }

        private void HeapifyUp(int index) {
            var parentIndex = (index + 1) / 2 - 1;

            while (parentIndex >= 0)
            {
                if (data[parentIndex].CompareTo(data[index])<0)
                    return;
                
                var tempT = data[parentIndex];
                data[parentIndex] = data[index];
                data[index] = tempT;

                ValueToIndex[data[parentIndex]] = parentIndex;
                ValueToIndex[data[index]] = index;
                
                index = parentIndex;
                parentIndex = (index + 1) / 2 - 1;
            }
        }

        private void HeapifyDown(int index)
        {
            //todo: check limits
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallestIndex;

            if (left >= data.Count)
                return;

            if (right >= data.Count)
            {
                smallestIndex = left;
            }
            else
            {
                smallestIndex = data[left].CompareTo(data[right]) < 0 ? left : right;
            }

            while (data[smallestIndex].CompareTo(data[index])<0)
            {
                var tempT = data[smallestIndex];
                data[smallestIndex] = data[index];
                data[index] = tempT;

                ValueToIndex[data[smallestIndex]] = smallestIndex;
                ValueToIndex[data[index]] = index;

                index = smallestIndex;
                left = 2 * index + 1;
                right = 2 * index + 2;
                
                if (left >= data.Count)
                    return;

                if (right >= data.Count)
                {
                    smallestIndex = left;
                }
                else
                {
                    smallestIndex = data[left].CompareTo(data[right]) < 0 ? left : right;
                }
            }
        }

        public void Insert(T o)
        {
            data.Add(o);

            int i = data.Count - 1;

            ValueToIndex[o] = i;

            while (i > 0)
            {
                int j = (i + 1) / 2 - 1;

                // Check if the invariant holds for the element in data[i]  
                T v = data[j];
                if (v.CompareTo(data[i]) < 0 || v.CompareTo(data[i]) == 0)
                {
                    break;
                }

                // Swap the elements  
                T tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;

                ValueToIndex[tmp] = j;
                ValueToIndex[data[i]] = i;

                i = j;
            }
        }

        public T ExtractMin()
        {
            if (data.Count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T min = data[0];
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            this.MinHeapify(0);
            return min;
        }

        public T Peek()
        {
            return data[0];
        }

        public int Count
        {
            get { return data.Count; }
        }

        private void Heapify(int i)
        {
            int left = 2 * 0 + 1;
            int right = 2 * 0 + 2;
            int smallest = (data[left].CompareTo(data[right]) < 0) ? left : right;

            if (left < data.Count && (data[left].CompareTo(data[i]) < 0))
            {
                smallest = left;
            }
            else
            {
                smallest = i;
            }

            if (right < data.Count && (data[right].CompareTo(data[smallest]) < 0))
            {
                smallest = right;
            }

            /*if (smallest == i && (data[smallest].CompareTo(data[0]) < 0))
            {
                T tmp = data[i];
                data[i] = data[0];
                data[0] = tmp;

                ValueToIndex[tmp] = 0;
                ValueToIndex[data[i]] = i;
                this.Heapify(i);
            }*/

            int min = (data[smallest].CompareTo(data[i]) < 0) ? smallest : i;
            int max = (data[smallest].CompareTo(data[i]) > 0) ? smallest : i;

            if (data[min].CompareTo(data[max]) < 0 && max != 0) { return; }

            if (min == max) { return; }


            T tmp = data[i];
            data[i] = data[smallest];
            data[smallest] = tmp;

            ValueToIndex[tmp] = smallest;
            ValueToIndex[data[i]] = i;
            this.Heapify(smallest);

        }
         
        private void MinHeapify(int i)
        {
            int smallest;
            int l = 2 * (i + 1) - 1;
            int r = 2 * (i + 1) - 1 + 1;

            if (l < data.Count && (data[l].CompareTo(data[i]) < 0))
            {
                smallest = l;
            }
            else
            {
                smallest = i;
            }

            if (r < data.Count && (data[r].CompareTo(data[smallest]) < 0))
            {
                smallest = r;
            }

            if (smallest != i)
            {
                T tmp = data[i];
                data[i] = data[smallest];
                data[smallest] = tmp;
                this.MinHeapify(smallest);
            }
        }
    }

    public class CustomHeap<T> where T: IComparable
    {
        private List<T> data = new List<T>();
        public Dictionary<T, int> ValueToIndex = new Dictionary<T, int>();

        public void UpdateValue(T oldValue, T newValue)
        {
            int index = ValueToIndex[oldValue];
            data[index] = newValue;
            ValueToIndex.Remove(oldValue);
            ValueToIndex[newValue] = index;

            Heapify(index);

            Console.Write(data[0] + " ");
        }

        private void Heapify(int i)
        {
            int left = 2 * 0 + 1;
            int right = 2 * 0 + 2;
            int smallest = (data[left].CompareTo(data[right]) < 0) ? left : right;

            if (left < data.Count && (data[left].CompareTo(data[i]) < 0))
            {
                smallest = left;
            }
            else
            {
                smallest = i;
            }

            if (right < data.Count && (data[right].CompareTo(data[smallest]) < 0))
            {
                smallest = right;
            }

            /*if (smallest == i && (data[smallest].CompareTo(data[0]) < 0))
            {
                T tmp = data[i];
                data[i] = data[0];
                data[0] = tmp;

                ValueToIndex[tmp] = 0;
                ValueToIndex[data[i]] = i;
                this.Heapify(i);
            }*/

                int min = (data[smallest].CompareTo(data[i]) < 0) ? smallest : i;
                int max = (data[smallest].CompareTo(data[i]) > 0) ? smallest : i;

                if (data[min].CompareTo(data[max]) < 0 && max != 0) { return; }

                if (min == max) { return; }


                T tmp = data[i];
                data[i] = data[smallest];
                data[smallest] = tmp;

                ValueToIndex[tmp] = smallest;
                ValueToIndex[data[i]] = i;
                this.Heapify(smallest);

        }

        public void Insert(T o)
        {
            data.Add(o);

            int i = data.Count - 1;

            ValueToIndex[o] = i; 

            while (i > 0)
            {
                int j = (i + 1) / 2 - 1;

                // Check if the invariant holds for the element in data[i]  
                T v = data[j];
                if (v.CompareTo(data[i]) < 0 || v.CompareTo(data[i]) == 0)
                {
                    break;
                }

                // Swap the elements  
                T tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;

                ValueToIndex[tmp] = j;
                ValueToIndex[data[i]] = i;

                i = j;
            }
        }

        public T ExtractMin()
        {
            if (data.Count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T min = data[0];
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            this.MinHeapify(0);
            return min;
        }

        public T Peek()
        {
            return data[0];
        }

        public int Count
        {
            get { return data.Count; }
        }

        private void MinHeapify(int i)
        {
            int smallest;
            int l = 2 * (i + 1) - 1;
            int r = 2 * (i + 1) - 1 + 1;

            if (l < data.Count && (data[l].CompareTo(data[i]) < 0))
            {
                smallest = l;
            }
            else
            {
                smallest = i;
            }

            if (r < data.Count && (data[r].CompareTo(data[smallest]) < 0))
            {
                smallest = r;
            }

            if (smallest != i)
            {
                T tmp = data[i];
                data[i] = data[smallest];
                data[smallest] = tmp;
                this.MinHeapify(smallest);
            }
        }
    }

    public class Heap<T> where T: IComparable
    {
        private List<T> data = new List<T>();

        public void Insert(T o)
        {
            data.Add(o);

            int i = data.Count - 1;
            while (i > 0)
            {
                int j = (i + 1) / 2 - 1;

                // Check if the invariant holds for the element in data[i]  
                T v = data[j];
                if (v.CompareTo(data[i]) < 0 || v.CompareTo(data[i]) == 0)
                {
                    break;
                }

                // Swap the elements  
                T tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;

                i = j;
            }
        }

        public T ExtractMin()
        {
            if (data.Count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T min = data[0];
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            this.MinHeapify(0);
            return min;
        }

        public T Peek()
        {
            return data[0];
        }

        public int Count
        {
            get { return data.Count; }
        }

        private void MinHeapify(int i)
        {
            int smallest;
            int l = 2 * (i + 1) - 1;
            int r = 2 * (i + 1) - 1 + 1;

            if (l < data.Count && (data[l].CompareTo(data[i]) < 0))
            {
                smallest = l;
            }
            else
            {
                smallest = i;
            }

            if (r < data.Count && (data[r].CompareTo(data[smallest]) < 0))
            {
                smallest = r;
            }

            if (smallest != i)
            {
                T tmp = data[i];
                data[i] = data[smallest];
                data[smallest] = tmp;
                this.MinHeapify(smallest);
            }
        }
    }
}
