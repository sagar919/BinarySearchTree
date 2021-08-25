using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BSTNode
    {
        public IComparable datam;
        public BSTNode leftChild;
        public BSTNode rightChild;

        public BSTNode(IComparable item)
        {
            datam = item;
        }
    }
}
