using System;

namespace PairWithGivenSumInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find pairs in BST with given sum!");
            Console.WriteLine("---------------------------------");

            try
            {
                BinarySearchTree binarySearchTree = InputProcessor.GetBinarySearchTreeFromInput();
                Console.WriteLine("Enter the sum for which pairs are to be found in the " +
                    "binary search tree");
                int sum = int.Parse(Console.ReadLine());
                InputProcessor.PrintPairsInBSTThatSumUpANumber(binarySearchTree, InputProcessor.sizeOfTree, sum);
            }
            catch (Exception exception) {
                Console.WriteLine("Program:Main: Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
