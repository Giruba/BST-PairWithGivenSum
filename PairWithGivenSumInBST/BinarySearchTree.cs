using System;
using System.Collections.Generic;
using System.Text;

namespace PairWithGivenSumInBST
{
    class BinarySearchTree
    {
        BinaryTreeNode root;
        private static int currentIndex = 0;

        public BinarySearchTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }


        public void SetBinarySearchTreeRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetBinarySearchTreeRoot() {
            return root;
        }


        public BinaryTreeNode Insert(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }

            if (binaryTreeNode.GetBinaryTreeNodeData() < data)
            {
                binaryTreeNode.SetBinaryTreeNodeRight(
                    Insert(binaryTreeNode.GetBinaryTreeNodeRight(), data));
            }
            else {
                binaryTreeNode.SetBinaryTreeNodeLeft(
                    Insert(binaryTreeNode.GetBinaryTreeNodeLeft(), data));
            }

            return binaryTreeNode;
        }

        public int[] GetInorderTraversalArray(BinaryTreeNode binaryTreeNode,int[] array) {
            if (binaryTreeNode == null)
            {
                return array;
            }
            else {
                array = GetInorderTraversalArray(binaryTreeNode.GetBinaryTreeNodeLeft(),array);
                array[currentIndex++] = binaryTreeNode.GetBinaryTreeNodeData();
                array = GetInorderTraversalArray(binaryTreeNode.GetBinaryTreeNodeRight(), array);
            }
            return array;
        }
    }
}
