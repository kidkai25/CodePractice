using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static List<int> stack1 = new List<int>();
        static List<int> stack2 = new List<int>();
        static int top1 = -1; //initial
        static int top2 = -1;
        static void Main(string[] args)
        {
            //Console.WriteLine(getMin());
            //pop();
            //Console.WriteLine(top());
            //push(1);
            //push(2);
            //push(-2);
            //Console.WriteLine(getMin());
            //pop();
            //var x = stack1;
            //var x2 = stack2;
            //Console.WriteLine(getMin());
            //Console.WriteLine(top());
            //Console.ReadLine();
            Console.WriteLine(solve("{([])}"));
            Console.WriteLine(solve("(){"));
            Console.WriteLine(solve("()[]"));
            Console.ReadLine();
        }
        public static int solve(string A)
        {
            Stack<char> stack = new Stack<char>(A.Length);
            foreach(var x in A)
            {
                if(x == '{' || x == '(' || x == '[')                
                    //open
                    stack.Push(x);                
                else if(stack.Count == 0) //first character is incorrect                
                    return 0;                
                else
                {
                    //closing found
                    var top = stack.Peek();
                    if ((top == '(' && x == ')') || (top == '{' && x == '}') || (top == '[' && x == ']'))
                        stack.Pop(); //pop the pair
                    else
                        return 0; //order mismatch
                }                
            }
            //check count
            if (stack.Count == 0)
                return 1;
            return 0;
        }
        public static void push(int x)
        {
            stack1.Insert(++top1, x);
            //getMin
            var y = getMin();
            if(y == -1)
                stack2.Insert(++top2, x);
            else if (x < y)
                stack2.Insert(++top2, x);
        }

        public static void pop()
        {
            //remove from both stacks
            if (top1 != -1) //do nothing
            {
                var y = getMin();
                var x = stack1[top1];
                if (x == y)
                    stack2.RemoveAt(top2--);
                stack1.RemoveAt(top1--);
            }

        }

        public static int top()
        {
            if (top1 == -1)
                return -1;
            return stack1[top1];
        }

        public static int getMin()
        {
            //return top of second stack1
            if (top2 == -1)
                return -1;
            return stack2[top2];
        }

    }
}
