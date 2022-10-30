using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq.Expressions;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(11);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(1);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);
            //root.left.left.left.left = new TreeNode(10);

            //var x = height(root);
            var x = HasPathSum(root, 22);
            Console.WriteLine(x);


        }

        static int HasPathSum(TreeNode A , int B)
        {
            return HelperPathSum(A, B) ? 1 : 0;  
            
        }
        static bool HelperPathSum(TreeNode root, int B)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null)
                return root.val == B;

            return HelperPathSum(root.left, B - root.val) || 
                HelperPathSum(root.right, B - root.val);            
        }
        static int height(TreeNode A)
        {
            if (A == null)
                return -1;
            return Math.Max(height(A.left), height(A.right)) + 1;
        }
    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x;this.left = this.right = null; }
    }
}