using System;
using System.Collections.Generic;
using System.Text;

namespace PairWithGivenSumInBST
{    
    class InputProcessor
    {
        public static int sizeOfTree = 0;
        public static BinarySearchTree GetBinarySearchTreeFromInput() {
            BinarySearchTree binarySearchTree = new BinarySearchTree(null);

            Console.WriteLine("Enter the number of nodes in the binary search tree");
            try{
                int numberOfNodes = int.Parse(Console.ReadLine());
                sizeOfTree = numberOfNodes;
                Console.WriteLine("Enter the values of the nodes in a single line" +
                    " separated by space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',',';');
                for (int index = 0; index < numberOfNodes; index++) {
                    binarySearchTree.SetBinarySearchTreeRoot(
                        binarySearchTree.Insert(binarySearchTree.GetBinarySearchTreeRoot(),
                        int.Parse(elements[index])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return binarySearchTree;
        }

        public static void PrintPairsInBSTThatSumUpANumber(BinarySearchTree binarySearchTree, int size, int sum)
        {
            int[] inorderArray = binarySearchTree.GetInorderTraversalArray(
                binarySearchTree.GetBinarySearchTreeRoot(), new int[size]);

            int startIndex = 0;
            int endIndex = size - 1;

            while (startIndex < endIndex)
            {
                if (inorderArray[startIndex] + inorderArray[endIndex] == sum)
                {
                    Console.WriteLine("Pair with sum " + sum + " found [" +
                        inorderArray[startIndex] + "," + inorderArray[endIndex] + "]");
                    startIndex++;
                    endIndex--;
                }
                else if (inorderArray[startIndex] + inorderArray[endIndex] < sum)
                {
                    startIndex++;
                }
                else if (inorderArray[startIndex] + inorderArray[endIndex] > sum)
                {
                    endIndex--;
                }
            }
        }
    }
}
