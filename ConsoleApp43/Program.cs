using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    /**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(8);
            root.right.right = new TreeNode(7);

            //input 2
            TreeNode root2 = new TreeNode(5);
            root2.left = new TreeNode(3);
            root2.right = new TreeNode(8);
            root2.left.left = new TreeNode(1);
            root2.left.right = new TreeNode(4);
            root2.right.right = new TreeNode(9);
            root2.right.left = new TreeNode(7);

            var x = Solve(root2);
            Console.WriteLine(x);
            x = Solve(root2);
            Console.WriteLine(x);
            Console.ReadLine();

        }

        public static int Solve(TreeNode A)
        {
            //Creating a array;
            return Inorder(A);
        }

        public static int Inorder(TreeNode A)
        {
            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            TreeNode curr = A;
            int max = int.MinValue;
            while(curr != null || treeNodes.Count > 0)
            {
                while(curr != null)
                {
                    treeNodes.Push(curr);
                    curr = curr.left;
                }

                curr = treeNodes.Pop();

                //check is BST?
                if(isValidBST(curr))
                {
                    //find height
                    max = Math.Max(max, CountNode(curr));
                }

                curr = curr.right;
            }
            return max;
        }

        public static bool isValidBST(TreeNode A)
        {
            return isValidBST(A, Int32.MinValue, Int32.MaxValue);
        }
        public static bool isValidBST(TreeNode A, int l, int r)
        {
            if (A == null)
                return true;
            if (A.val >= l && A.val <= r)
            {
                return (isValidBST(A.left, l, A.val - 1)  &&
                        isValidBST(A.right, A.val + 1, r) );
            }
            return false;
        }

        public static int Height(TreeNode A)
        {
            if (A == null)
                return 0;
            else
            {
                int lh = Height(A.left);
                int rh = Height(A.right);

                if (lh > rh)
                    return lh + 1;
                else
                    return rh + 1;
            }
        }
        public static int CountNode(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + CountNode(root.left) + CountNode(root.right);   
        }
    }
}
