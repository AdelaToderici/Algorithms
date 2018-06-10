using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class TwoIntegersLinkedList
    {
        public static Node AddTwoIntegers(Node root1, Node root2)
        {
            Node current1 = root1;
            Node current2 = root2;
            int counter1 = 0;
            int counter2 = 0;

            while (current1.next != null)
            {
                counter1++;
                current1 = current1.next;
            }

            while (current2.next != null)
            {
                counter2++;
                current2 = current2.next;
            }

            int diff = 0;
            current1 = root1;
            current2 = root2;
            Tuple<Node, int> result = default(Tuple<Node, int>);
            Tuple<Node, int> unpaired = default(Tuple<Node, int>);

            if (counter1 > counter2)
            {
                while (diff < counter1 - counter2)
                {
                    diff++;
                    current1 = current1.next;
                }
                result = AddInteger(current1, root2);
                unpaired = AddUnpairedItems(root1, result, diff);
                return CreateNode(unpaired.Item1, unpaired.Item2);
            }

            if (counter2 > counter1)
            {
                while (diff < counter2 - counter1)
                {
                    diff++;
                    current2 = current2.next;
                }
                result = AddInteger(root1, current2);
                unpaired = AddUnpairedItems(root2, result, diff);
                return CreateNode(unpaired.Item1, unpaired.Item2);
            }

            result = AddInteger(root1, root2);

            return CreateNode(result.Item1, result.Item2);
        }

        private static Node CreateNode(Node root, int carry)
        {
            if (carry > 0)
            {
                int nodeValue = (root.value + carry) % 10;
                return new Node(root, nodeValue);
            }
            return root;
        }

        private static Tuple<Node, int> AddUnpairedItems(Node root, Tuple<Node, int> prevResult, int diff)
        {
            if (diff == 1)
            {
                int nodeValueX = (root.value + prevResult.Item2) % 10;
                int carryX = nodeValueX / 10;
                Node newRootX = new Node(prevResult.Item1, nodeValueX);

                return Tuple.Create(newRootX, carryX);
            }

            Tuple<Node, int> result = default(Tuple<Node, int>);

            result = AddUnpairedItems(root.next, prevResult, diff - 1);

            int nodeValue = (root.value + result.Item2) % 10;
            int carry = nodeValue / 10;

            Node newRoot = new Node(result.Item1, nodeValue);

            return Tuple.Create(newRoot, carry);
        }

        private static Tuple<Node, int> AddInteger(Node root1, Node root2)
        {
            if (root1 == null && root2 == null) { return null; }

            var result = AddInteger(root1.next, root2.next);

            if (result == null)
            {
                int sumX = root1.value + root2.value;
                int nodeValueX = sumX % 10;
                int carryX = sumX / 10;

                Node newRootX = new Node(null, nodeValueX);

                return Tuple.Create(newRootX, carryX);
            }

            int sum = root1.value + root2.value + result.Item2;
            int nodeValue = sum % 10;
            int carry = sum / 10;

            Node newRoot = new Node(result.Item1, nodeValue);

            return Tuple.Create(newRoot, carry);
        }
    }
}
