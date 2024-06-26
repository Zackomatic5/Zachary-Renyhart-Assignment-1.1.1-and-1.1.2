namespace Zachary_Renyhart_Assignment_8._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode();
             tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(2);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(4);
            tree.right.left = new TreeNode(4);
            tree.right.right = new TreeNode(3);
            if (IsSymmetric(TreeNode, tree))
            {
                Console.WriteLine("Symmetrical");

            }
            else
            {
                Console.WriteLine("Not Symmetrical");
            }
               
            

        }

        public bool IsSymmetric(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                TreeNode left = queue.Dequeue();
                TreeNode right = queue.Dequeue();

                if (left == null && right == null)
                {   //If both sides of the tree == null then they could be equal.
                    continue;
                }
                else if (left == null || right == null)
                {   //If one of the nodes are null its not symmetiral
                    return false;
                }
                else if (left.value != right.value)
                {   //If the value of nodes are not equal this will return false.
                    return false;
                }
                else
                {   //This is pushing the left and right subtrees of the left and
                    //right nodes onto the queue in opposite order
                    queue.Enqueue(left.left);
                    queue.Enqueue(right.right);
                    queue.Enqueue(left.right);
                    queue.Enqueue(right.left);
                }
            }

            return true;
        }

    }
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

    }
     

}
