using BinaryTree;


namespace Day_27_Adding_a_pakcage
{
    internal class Program
    {
        static void Main(string[] args)
            //We added the Binary Tree package.
        {
            //Instantiate a new binary tree   //This is a constructor
            BinaryTree<int> binarytree = new BinaryTree<int>();
            //This is creating the binary tree and adding a bunch of nodes.
            binarytree.Add(8);
            binarytree.Add(5);
            binarytree.Add(12);
            binarytree.Add(27);
            binarytree.Add(35);
            binarytree.Add(11);
            binarytree.Add(22);
            binarytree.Add(15);
            binarytree.Add(13);
           
            foreach (var item in binarytree)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //This is using the methods inside the package
            binarytree.PrintToConsole();
            //This is printing the binary tree
            binarytree.PrintAsTree();
            //This displays true if the binary tree contains "8".
           
        }

    }
}
