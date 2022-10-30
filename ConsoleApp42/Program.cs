using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            root.left.left.left = new TreeNode(8);

            var list = SolveVerticalOrder(root);
            Console.ReadLine();




        }
        static List<int> SolveLeftView(TreeNode A)
        {
            List<int> a = new List<int>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();

            treeNodes.Enqueue(A);
            treeNodes.Enqueue(null);            
            TreeNode temp = null;
            a.Add(A.val);
            while (treeNodes.Count > 1)
            {
                var x = treeNodes.Dequeue();

                if (x == null)
                {
                    treeNodes.Enqueue(null);
                    a.Add(temp.val);
                    temp = null;
                }
                else
                {                                        
                    if (x.left != null)
                    {
                        treeNodes.Enqueue(x.left);
                        if(temp == null)
                            temp = x.left;
                    }
                    if (x.right != null)
                    {
                        treeNodes.Enqueue(x.right);
                        if (temp == null) //temp is still null
                            temp = x.right;
                    }
                }
            }
            
            //
            foreach(var x in a)
            {
                Console.WriteLine(x);
            }
            return a;
            //Console.ReadLine();
        }

        static List<int> SolveRightView(TreeNode A)
        {
            List<int> a = new List<int>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();

            treeNodes.Enqueue(A);
            treeNodes.Enqueue(null);
            TreeNode temp = null;
            a.Add(A.val);
            while (treeNodes.Count > 1)
            {
                var x = treeNodes.Dequeue();

                if (x == null)
                {
                    treeNodes.Enqueue(null);
                    a.Add(temp.val);
                    temp = null;
                }
                else
                {                    
                    if (x.right != null)
                    {
                        treeNodes.Enqueue(x.right);
                        if (temp == null) //temp is still null
                            temp = x.right;
                    }
                    if (x.left != null)
                    {
                        treeNodes.Enqueue(x.left);
                        if (temp == null)
                            temp = x.left;
                    }
                }
            }

            //Print
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x);
            //}
            return a;
            //Console.ReadLine();
        }

        static List<int> SolveVerticalOrder(TreeNode A)
        {
            //HashMap
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            Queue<Tuple<TreeNode, int>> treeNodes = new Queue<Tuple<TreeNode, int>>();

            //First Enqueue :D
            var root = Tuple.Create(A, 0);
            treeNodes.Enqueue(root);
            int level = 0;
            int min_level = int.MaxValue;
            int max_level = int.MinValue;
            while(treeNodes.Count > 0)
            {
                //dequeue
                var curr = treeNodes.Dequeue();
                level = curr.Item2;
                //insert left child in the queue
                if(curr.Item1.left != null)
                {
                    var leftChild = Tuple.Create(curr.Item1.left, level - 1);
                    treeNodes.Enqueue(leftChild);
                }
                if(curr.Item1.right != null)
                {
                    var rightChild = Tuple.Create(curr.Item1.right, level + 1);
                    treeNodes.Enqueue(rightChild);
                }

                if (dic.ContainsKey(level))
                    dic[level].Add(curr.Item1.val);
                else
                    dic.Add(level, new List<int>() { curr.Item1.val });
                //find max key
                min_level = Math.Min(min_level, level);
                max_level = Math.Max(max_level, level);
            }

            List<List<int>> ans = new List<List<int>>();
            //final loop
            for (int i = min_level; i <= max_level; i++)
            {
                //Console.WriteLine(dic[i].First());
                ans.Add(dic[i]);
            }
            return ans;
            //Console.ReadLine();
        }


        static List<List<int>> verticalOrderTraversal(TreeNode A)
        {
            //HashMap
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            Queue<Tuple<TreeNode, int>> treeNodes = new Queue<Tuple<TreeNode, int>>();

            //First Enqueue :D
            var root = Tuple.Create(A, 0);
            treeNodes.Enqueue(root);
            int level = 0;
            int min_level = int.MaxValue;
            int max_level = int.MinValue;
            while (treeNodes.Count > 0)
            {
                //dequeue
                var curr = treeNodes.Dequeue();
                level = curr.Item2;
                //insert left child in the queue
                if (curr.Item1.left != null)
                {
                    var leftChild = Tuple.Create(curr.Item1.left, level - 1);
                    treeNodes.Enqueue(leftChild);
                }
                if (curr.Item1.right != null)
                {
                    var rightChild = Tuple.Create(curr.Item1.right, level + 1);
                    treeNodes.Enqueue(rightChild);
                }

                if (dic.ContainsKey(level))
                    dic[level].Add(curr.Item1.val);
                else
                    dic.Add(level, new List<int>() { curr.Item1.val });
                //find max key
                min_level = Math.Min(min_level, level);
                max_level = Math.Max(max_level, level);
            }

            List<List<int>> ans = new List<List<int>>();
            //final loop
            for (int i = min_level; i <= max_level; i++)
            {
                //Console.WriteLine(dic[i].First());
                ans.Add(dic[i]);
            }
            return ans;
        }
    }
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }
}
