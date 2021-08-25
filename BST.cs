using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST
    {
        BSTNode root;



        public BST()
        {
            root = null;
        }


        public bool Empty
        {
            get { return root == null; }
        }

        public void Insert(IComparable item)
        {
            BSTNode newNode = new BSTNode(item);
            if (root == null)
            {
                root = newNode;
                return;
            }

            BSTNode t = root, p = null;
            bool wentLeft = false;
            while (t != null)
            {
                if (t.datam.CompareTo(item) == 0)
                    throw new Exception("Item already in the tree");

                else if (t.datam.CompareTo(item) < 0)
                {
                    p = t;
                    t = t.rightChild;
                    wentLeft = false;
                }

                else
                {
                    p = t;
                    t = t.leftChild;
                    wentLeft = true;
                }
            }
            if (wentLeft)
                p.leftChild = newNode;
            else
                p.rightChild = newNode;

        }

        public void Remove(IComparable target)
        {
            BSTNode t = root, p = null;
            bool wentLeft = false;

            while (t != null && t.datam.CompareTo(target) != 0)
            {
                if (t.datam.CompareTo(target) < 0)
                {
                    p = t;
                    t = t.rightChild;
                    wentLeft = false;
                }
                else
                {
                    p = t;
                    t = t.leftChild;
                    wentLeft = true;
                }

            }

            if (t == null) throw new Exception
                   ("Item not in tree");

            if (t.leftChild == null && t.rightChild == null)
            {
                if (t == root)
                {
                    root = null;
                }
                else
                {
                    if (wentLeft)
                        p.leftChild = null;
                    else
                        p.rightChild = null;
                }
            }
            else if (t.leftChild == null)
            {
                if (t == root)
                {
                    root = t.rightChild;
                }
                else
                {
                    if (wentLeft)
                        p.leftChild = t.rightChild;
                    else
                        p.rightChild = t.rightChild;
                }
            }
            else if (t.rightChild == null)
            {
                if (t == root)
                {
                    root = t.leftChild;
                }
                else
                {
                    if (wentLeft)
                        p.leftChild = t.leftChild;
                    else p.rightChild = t.leftChild;
                }
            }
            else
            {
                BSTNode tp = t;
                BSTNode travel = t.leftChild;
                while (travel.rightChild != null)
                {
                    tp = travel;
                    travel = travel.rightChild;
                }
                t.datam = travel.datam;
                if (tp == t)
                    tp.leftChild = travel.leftChild;
                else
                    tp.rightChild = travel.rightChild;
            }

        }

        public IComparable Get(IComparable target)
        {
            return recursiveGet(root, target);
        }

        private IComparable recursiveGet(BSTNode treepoint, IComparable target)
        {
            IComparable answer = null;
            if (treepoint == null) throw new Exception
                     ("item not in the tree");
            else if (treepoint.datam.CompareTo(target) < 0)
                answer = recursiveGet(treepoint.rightChild, target);
            else if (target.CompareTo(treepoint.datam) < 0)
                answer = recursiveGet(treepoint.leftChild, target);
            else answer = treepoint.datam;
            return answer;
        }

        public void CLear()
        {
            root = null;
        }


    }
}
