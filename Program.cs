using System;


public class Node
{

	public int data;
	public Node left, right;

	public Node(int d)
	{
		data = d;
		left = right = null;
	}
}

public class BinaryTree
{

	public static Node root;

	
	public virtual Node sortedArrayToBST(int[] arr, int start, int end)
	{

		
		if (start > end)
		{
			return null;
		}

		
		int mid = (start + end) / 2;
		Node node = new Node(arr[mid]);

		node.left = sortedArrayToBST(arr, start, mid - 1);

		
		node.right = sortedArrayToBST(arr, mid + 1, end);

		return node;
	}

	
	public virtual void preOrder(Node node)
	{
		if (node == null)
		{
			return;
		}

		preOrder(node.left);
		Console.Write(node.data + " ");
		preOrder(node.right);
	}

	public static void Main(string[] args)
	{
		BinaryTree tree = new BinaryTree();
		int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
		int n = arr.Length;
		root = tree.sortedArrayToBST(arr, 0, n - 1);
		Console.WriteLine("Preorder traversal of constructed BST");
		tree.preOrder(root);
	}
}


