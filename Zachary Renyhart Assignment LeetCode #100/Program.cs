using System.Security.Cryptography.X509Certificates;
using Zachary_Renyhart_Assignment_LeetCode__100;

namespace Zachary_Renyhart_Assignment_LeetCode__100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            TreeNode root2 = new TreeNode();

            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);


            root2 = new TreeNode(1);
            root2.left = new TreeNode(2);
            root2.right = new TreeNode(3);




            //LEETCODE #100
            //The IF statement is stating that if both trees are the same they will be equal, if not they will be false.
            if (IsSameTreeLeetCode(root, root2))
            {
                Console.WriteLine("Both trees are equal");
            }
            else
            {
                Console.WriteLine("Both trees are not equal");
            }
        }




        //This was accepted by LeetCode and completed with a runtime of 63MS!!
        public static bool IsSameTreeLeetCode(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null)
            {
                return false;
            }

            if (root1.value != root2.value)
            {
                return false;
            }
            //This is a recursive method calling out the left side and right side of the trees.
            //Inside the method is what will display true and false based on if the nodes are equal or not
            return IsSameTreeLeetCode(root1.left, root2.left) && IsSameTreeLeetCode(root1.right, root2.right);
        }


    }


    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = val;
            this.left = left;
            this.right = right;
        }
    }
}

