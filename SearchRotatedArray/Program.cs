using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class Program
    {
        // https://www.educative.io/collection/page/5642554087309312/5679846214598656/100002/preview
        static int FindElemInRotatedArray(int[] A, int k, int start, int end)
        {
            if (A[start] == k)
            {
                return start;
            }
            if (A[end] == k)
            {
                return end;
            }

            if (A[start] > k)
            {
                int midd = start + ((end - start) / 2);
                if (A[midd] == k)
                {
                    return midd;
                }
                if (A[midd] > k && A[midd] < A[start])
                {
                    return FindElemInRotatedArray(A, k, start, midd - 1);
                }
                return FindElemInRotatedArray(A, k, midd + 1, end);
            }
            else
            {
                int midd = start + ((end - start) / 2);
                if (A[midd] == k)
                {
                    return midd;
                }
                if (A[midd] < A[start])
                {
                    return FindElemInRotatedArray(A, k, start + 1, midd - 1);
                }
                if (A[midd] > k)
                {
                    return FindElemInRotatedArray(A, k, start, midd - 1);
                }
                return FindElemInRotatedArray(A, k, midd + 1, end);
            }
        }

        static void Main(string[] args)
        {
            //int[] A = new int[] { 7, 4, 2, 5, 9, 11, 6, 8, 3 };
            //int[] A = new int[] { 7, 4, 10, 3, 2, 5, 9, 1, 11, 6, 8, -1 };
            //MaxSlidingWindow.FindMaxElementInWindow(A, 5);

            // int[] A = new int[] { 15, 22, 34, 38, 48 };
            // int[] B = new int[] { 27, 39, 48, 50, 56 };
            // int[] C = new int[] { 20, 29, 33, 48, 50 };
            //
            // int result = SmallestNrSortedArrays.FindSmallestCommonNrInSortedArrays(A, B, C);
            // Console.Write(result);
            //
            // Console.Read();

            //   int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //   var result = RotateArray.RotateGivenArray(A, 3);
            //   Console.WriteLine(String.Join(", ", result));
            //   Console.Read();

            //    int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 7, 7, 7, 8, 9, 10 };
            //    var result = LowHighIndex.FindLowHighIndexes(A, 7);
            //    Console.WriteLine(String.Join(", ", result));
            //    Console.Read();

            /* int result = FindElemInRotatedArray(A, 8, 0, A.Length - 1);
            Console.Write(result); */

            //   int[] A = new int[] { 2, 3, 0, 4, 7, 0, 9, 10, 0, 11 };
            //   var result = ZerosToLeft.MoveZerosToLeft(A);
            //   Console.Write(String.Join(", ", result));
            //   Console.Read();

            //   int[] A = new int[] { 7, 2, 4, 14, 1, 9, 5, 14 };
            //   var result = MaximumSellProfit.FindMaximumSellProfit(A);
            //   Console.Write(result);
            //   Console.Read();

            //   int[] A = new int[] { 1, 2, 5, 4, -1, -2, 3 };
            //   QuickSort.QuickSortArray(A, 0, A.Length - 1);
            //   Console.Write(String.Join(", ", A));
            //   Console.Read();

            //  List<Interval> list = new List<Interval>();
            //  list.Add(new Interval(1, 3));
            //  list.Add(new Interval(2, 4));
            //  list.Add(new Interval(5, 7));
            //  list.Add(new Interval(6, 8));
            //
            //  var result = OverlappingInterval.MergeOverlappingIntervals(list);
            //  Console.WriteLine(String.Join(", ", result));
            //  Console.Read();

            //   int[] A = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            //   Tuple<int, int> result = TwoValuesSum.FindTwoValuesForSum(A, 10);
            //
            //   if (result != null)
            //   {
            //       Console.Write("(" + result.Item1 + ", " + result.Item2 + ")");
            //   } else
            //   {
            //       Console.Write("Result not found.");
            //   }
            //   
            //   Console.Read();

            //   Node n_28 = new Node(null, 28);
            //   Node n_21 = new Node(n_28, 21);
            //   Node n_14 = new Node(n_21, 14);
            //   Node root = new Node(n_14, 7);
            //
            //   //var result = ReversedLinkedList.ReverseASinglyLinkedList(root);
            //   var result = ReversedLinkedList.ReverseLinkListRecursively(root);
            //   Console.Write(String.Join(", ", result));
            //   Console.Read();

            //   Node n_2_2 = new Node(null, 2);
            //   Node n_4 = new Node(n_2_2, 4);
            //   Node n_3_2 = new Node(n_4, 3);
            //   Node n_3 = new Node(n_3_2, 3);
            //   Node n_2 = new Node(n_3, 2);
            //   Node root = new Node(n_2, 1);

            //var result = DuplicatesLinkedList.RemoveDuplicates(root);

            //var result = DeleteNodeLinkedList.DeleteNodeForGivenKey(root, 3);
            //
            //while (result != null)
            //{
            //    Console.Write(result.value+" -> ");
            //    result = result.next;
            //}

            //   int[] A = new int[] { 7, 8, 5, 2, 4, 6, 3 };
            //   var result = InsertionSort.SortArray(A);
            //   Console.Write(String.Join(", ", result));
            //
            //   Console.Read();

            //   Node n_3 = new Node(null, 3);
            //   Node n_6 = new Node(n_3, 6);
            //   Node n_4 = new Node(n_6, 4);
            //   Node n_2 = new Node(n_4, 2);
            //   Node n_5 = new Node(n_2, 5);
            //   Node n_8 = new Node(n_5, 8);
            //   Node root = new Node(n_8, 7);
            //
            //   var result = InsertionSortLinkedList.SortList(root);
            //   while (result != null)
            //   {
            //       Console.Write(result.value+" -> ");
            //       result = result.next;
            //   }
            //   Console.Read();

            //  Node n1_3 = new Node(null, 3);
            //  Node n1_2 = new Node(n1_3, 2);
            //  Node n1_5 = new Node(n1_2, 5);
            //  Node n1_10 = new Node(n1_5, 10);
            //  Node n1_8 = new Node(n1_10, 8);
            //  Node root1 = new Node(n1_8, 7);
            //
            //  Node n2_6 = new Node(n1_5, 6);
            //  Node root2 = new Node(n2_6, 9);
            //
            //  //var result = IntersectionPointLinkedList.FindIntersectionRecursively(root1, root2);
            //  //var result = NthNodeLinkedList.FindNthLastNode(root1, 3);
            //  var result = SwapNthNode.SwapNthNodeWithHead2(root1, 3);
            //  while (result != null)
            //  {
            //      Console.Write(result.value+" -> ");
            //      result = result.next;
            //  }
            //  Console.Read();

            //   Node n1_11 = new Node(null, 11);
            //   Node n1_8 = new Node(n1_11, 8);
            //   Node n1_7 = new Node(n1_8, 7);
            //   Node root2 = new Node(n1_7, 6);
            //
            //   Node n1_10 = new Node(null, 10);
            //   Node n1_5 = new Node(n1_10, 5);
            //   Node n1_3 = new Node(n1_5, 3);
            //   Node root1 = new Node(n1_3, 2);

            // var result = MergeLinkedLists.Merge(root1, root2);
            // while (result != null)
            // {
            //     Console.Write(result.value+" -> ");
            //     result = result.next;
            // }
            // Console.Read();

            // Node n1_11 = new Node(null, 11);
            // Node n1_8 = new Node(n1_11, 8);
            // Node n1_7 = new Node(n1_8, 7);
            // Node root2 = new Node(n1_7, 6);
            //
            // Node n1_10 = new Node(root2, 10);
            // Node n1_5 = new Node(n1_10, 5);
            // Node n1_3 = new Node(n1_5, 3);
            // Node root1 = new Node(n1_3, 2);

            //var result = MergeSortLinkedList.SortList(root1);

            //var result = RotateLinkedList.RotateList(root1, 3);

            //var result = ReversedKLinkedList.ReverseKElements(root1, 3);

            //   Node n1_4 = new Node(null, 4);
            //   Node n1_9 = new Node(n1_4, 9);
            //   Node n1_8 = new Node(n1_9, 8);
            //   Node n1_7 = new Node(n1_8, 8);
            //   Node root2 = new Node(n1_7, 6);
            //
            //   Node n1_2 = new Node(null, 2);
            //   Node n1_5 = new Node(n1_2, 5);
            //   Node n1_3 = new Node(n1_5, 3);
            //   Node root1 = new Node(n1_3, 1);
            //
            //   var result = TwoIntegersLinkedList.AddTwoIntegers(root1, root2);
            //   while (result != null)
            //   {
            //       Console.Write(result.value + " -> ");
            //       result = result.next;
            //   }
            //   Console.Read();

            //   var result = ReverseWords.ReverseWordsInSentence("ade e sefa in casa asta");
            //   Console.WriteLine(result);
            //   Console.Read();

            //   var result = StringDuplicates.RemoveStringDuplicates("aabbbbccdddefghefg");
            //   Console.WriteLine(String.Join(" ", result));
            //   Console.Read();

            //  Dictionary<int, string> dict = new Dictionary<int, string>();
            //  dict.Add(0, "i");
            //  dict.Add(1, "love");
            //  dict.Add(2, "to");
            //  dict.Add(3, "draw");
            //  dict.Add(4, "sweet");
            //  dict.Add(5, "monsters");
            //  dict.Add(6, "tonight");
            //
            //  var result = StringSegmentation.FindInputInDict(dict, "ilovemonster");
            //  Console.WriteLine(result ? "YES" : "NO");
            //  Console.Read();

            // var result = Palindrome.FindPalindromeSubstrings("abcdsdcddsabbas");
            //
            // Console.WriteLine(result);
            // Console.Read();

            //   TreeNode n_0 = new TreeNode(null, null, 0);
            //   TreeNode n_1 = new TreeNode(null, n_0, 1);
            //   TreeNode n_2 = new TreeNode(null, null, 2);
            //   TreeNode n_3 = new TreeNode(null, null, 3);
            //   TreeNode n_4 = new TreeNode(null, null, 4);
            //
            //   TreeNode n_5 = new TreeNode(n_1, n_2, 5);
            //   TreeNode n_6 = new TreeNode(n_3, n_4, 6);
            //   TreeNode n_7 = new TreeNode(n_5, n_6, 7);
            //
            //   TreeNode m_0 = new TreeNode(null, null, 0);
            //   TreeNode m_1 = new TreeNode(null, m_0, 1);
            //   TreeNode m_2 = new TreeNode(null, null, 2);
            //   TreeNode m_3 = new TreeNode(null, null, 3);
            //   TreeNode m_4 = new TreeNode(null, null, 4);
            //
            //   TreeNode m_5 = new TreeNode(m_1, m_2, 5);
            //   TreeNode m_6 = new TreeNode(m_3, m_4, 6);
            //   TreeNode m_7 = new TreeNode(m_5, m_6, 7);
            //
            //   var result = IdenticalTrees.FindIdentialTrees2(n_7, m_7);
            //   Console.Write(result ? "true" : "false");
            //   Console.Read();

            // TreeNode n_9 = new TreeNode(null, null, 9);
            // TreeNode n_8 = new TreeNode(null, n_9, 8);
            // TreeNode n_6 = new TreeNode(null, null, 6);
            // TreeNode n_7 = new TreeNode(n_6, n_8, 7);
            //
            // TreeNode n_1 = new TreeNode(null, null, 1);
            // TreeNode n_17 = new TreeNode(null, null, -1);
            // TreeNode n_4 = new TreeNode(n_17, null, 4);
            // TreeNode n_2 = new TreeNode(n_1, null, 2);
            // TreeNode n_3 = new TreeNode(n_2, n_4, 3);
            //
            // TreeNode n_5 = new TreeNode(n_3, n_7, 5);

            //IterativeInorder.Inorder(n_1);
            //var result = LevelOrderTraversal.Iterate(n_1);

            //  var result = BinarySearchTree.IsBST(n_5);
            //  Console.Write(result ? "true" : "false");

            //var result = LongestPath.FindLongestPath(n_5);
            //Console.Write(result);

            //var result = TreeToLinkedList.ConvertTreeToDoubleLinkedList(n_5);

            //var serializer = SerializeDeserializeBinaryTree.SerializeTree(n_5);
            //var deserializer = SerializeDeserializeBinaryTree.DeserializeList(serializer.Item1, serializer.Item2);

            //TreeMirror.Mirror(n_5);

            TreeNode n_m1 = new TreeNode(null, null, 28);
            TreeNode n_m6 = new TreeNode(null, null, 34);
            TreeNode n_1_1 = new TreeNode(n_m1, n_m6, 31);

            TreeNode n_5 = new TreeNode(null, null, 3);
            TreeNode n_4 = new TreeNode(n_5, null, 20);
            TreeNode n_m3 = new TreeNode(n_4, n_1_1, 23);

            TreeNode n_6 = new TreeNode(null, null, 18);
            TreeNode n_1 = new TreeNode(n_6, null, 5);

            TreeNode n_2 = new TreeNode(n_1, n_m3, 12);

            
            TreeNode n_31 = new TreeNode(null, null, 31);
            TreeNode n_18 = new TreeNode(null, null, 18);
            TreeNode n_20 = new TreeNode(n_18, null, 20);
            TreeNode n_23 = new TreeNode(n_20, n_31, 23);

            //var result = ZeroSumTree.DeleteZeroSum(n_2);

            // var result = MaxWidthTree.FindMaxWidth(n_2);

            //BTRightSideView.FetchRightSideNodes(n_2);

            //ZigZagBinaryTree.ZigZag(n_2);

            //   int[] A = new int[] { 24, 8, 3, 12, 2, 5, 6};
            //   var result = BTFactors.FindBTFactors(A);
            //   Console.Write(result);

            //  var result = UniqueBST.UniqueBSTCount(4);
            //  Console.Write(result);

            //var result = PathSumRL.PathSumExists(n_2, 14);

            // var result = PathSum.PathExists(n_2, 19);
            // Console.Write((result) ? "True" : "False");

            //var result = LargestBSTinBT.FindLargestBST(n_2);
            //Console.Write(result);

            // List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            // list.Add(new Tuple<int, string>(12, "N"));
            // list.Add(new Tuple<int, string>(11, "L"));
            // list.Add(new Tuple<int, string>(23, "N"));
            // list.Add(new Tuple<int, string>(20, "N"));
            // list.Add(new Tuple<int, string>(18, "L"));
            // list.Add(new Tuple<int, string>(16, "L"));
            // list.Add(new Tuple<int, string>(31, "N"));
            // list.Add(new Tuple<int, string>(28, "L"));
            // list.Add(new Tuple<int, string>(34, "L"));
            //
            // var result = TreeFromArray.ConvertPreorderArrayToTree(list);

            //var result = LCA.FindLCA(n_2, n_5, n_m6);

            //var result = MaxLevelCountBT.FindMaxLevel(n_2);

            //var result = SubtreeInTree.IsSubtree(n_2, n_23);
            //Console.Write(result ? "true" : "false");

            //var result = LargestSumSubtree.FindSum(n_2);
            //Console.Write(result.value);

            //VerticalTree.PrintVerticalNodes(n_2);

            var result = SwapBSTNodes.SwapNodes(n_2);
            Console.Write(result);

            Console.Read();
        }
    }
}
