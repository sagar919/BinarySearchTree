using System;
using System.Text;


namespace BinarySearchTree
{
    public class TestBinarySearchTree
    {
        static void Main()
        {
            BST bst = new BST();
            String result = "";

            DisplayHeader();
            char option = Console.ReadLine()[0];
            while (option != 'Q')
            {
                switch (option)
                {
                    case 'I':
                        Console.WriteLine("enter item: ");
                        bst.Insert(Console.ReadLine());
                        break;

                    case 'G':
                        Console.WriteLine("Enter item");
                        try
                        {
                            result = (String)bst.Get(Console.ReadLine());
                        }
                        catch (Exception ne)
                        {
                            Console.WriteLine(ne);
                        }
                        Console.WriteLine(result);
                        break;

                    case 'S':
                        Console.WriteLine(bst.ToString());
                        break;

                    case 'X':
                        bst.CLear();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }

                DisplayHeader();
                option = Console.ReadLine()[0];
            }
        }
        static void DisplayHeader()
        {
            Console.WriteLine("Enter one of the following");
            Console.WriteLine("I-Insert");
            Console.WriteLine("G-Get");            
            Console.WriteLine("X-clear bst");
            Console.WriteLine("Q-Quit");

        }

    }





}



















//public override string ToString()
//{
//    StringBuilder s = new StringBuilder("");
//    recursiveToString(root, s);
//    return s.ToString();

//}

//public void recursiveToString(BSTNode p, StringBuilder output)
//{
//    if (p != null)
//    {
//        recursiveToString(p.leftChild, output);
//        output.Append(" " + p.datam.ToString());
//        recursiveToString(p.rightChild, output);
//    }
//}

//Console.WriteLine("S-how text");