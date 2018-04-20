using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class Interval
    {
        public int beg;
        public int end;

        public Interval(int beg, int end)
        {
            this.beg = beg;
            this.end = end;
        }
    }

    public class OverlappingInterval
    {
        public static List<Interval> MergeOverlappingIntervals(List<Interval> list)
        {
            list = list.OrderBy(x => x.beg).ToList();

            Stack<Interval> stack = new Stack<Interval>();
            stack.Push(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                int start = stack.Peek().beg;
                int end = stack.Peek().end;

                if (list[i].beg <= end)
                {
                    stack.Pop();
                    stack.Push(new Interval(Math.Min(list[i].beg, start), list[i].end));
                }
                else
                {
                    stack.Push(new Interval(list[i].beg, list[i].end));
                }
            }

            return stack.ToList().OrderBy(x => x.beg).ToList();
        }
    }
}
