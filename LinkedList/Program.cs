using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> l = new List<List<int>>();
            //l.Add(new List<int> {0,1,-1 });
            //l.Add(new List<int> { 1, 2, -1 });
            //l.Add(new List<int> { 2, 3, 1 });

            //l.Add(new List<int> { 0, 1, -1 });
            //l.Add(new List<int> { 1, 2, -1 });
            //l.Add(new List<int> { 2, 3, 1 });
            //l.Add(new List<int> { 0, 4, -1 });
            //l.Add(new List<int> { 3, 1, -1 });
            //l.Add(new List<int> { 3, 2, -1 });

            //l.Add(new List<int> { 1, 13, -1 }); // 13
            //l.Add(new List<int> { 3, 0, -1 });  // NULL
            //l.Add(new List<int> { 3, 1, -1 }); // NULL
            //l.Add(new List<int> { 2, 15, 0 }); //NULL
            //l.Add(new List<int> { 3, 0, -1 }); //NULL
            //l.Add(new List<int> { 1, 12, -1 }); //12
            //l.Add(new List<int> { 3, 0, -1 }); //NULL
            //l.Add(new List<int> { 1, 19, -1 }); //19
            //l.Add(new List<int> { 1, 13, -1 });//19 ,13
            //l.Add(new List<int> { 3, 0, -1 }); //13
            //l.Add(new List<int> { 0, 12, -1 }); //12,13
            //l.Add(new List<int> { 1, 13, -1 });//12,13
            //l.Add(new List<int> { 3, 2, -1 });//12,13

            //l.Add(new List<int> { 2, 18, 0 });
            //l.Add(new List<int> { 2, 5, 1 });
            //l.Add(new List<int> { 2, 8, 0 });
            //l.Add(new List<int> { 1, 7, -1 });
            //l.Add(new List<int> { 1, 5, -1 });


            l.Add(new List<int> { 2, 1, 0 }); //1
            l.Add(new List<int> { 3, 0, -1 });//null
            l.Add(new List<int> { 0, 15, -1 });//15
            l.Add(new List<int> { 3, 0, -1 });//null
            l.Add(new List<int> { 0, 8, -1 });//8

            l.Add(new List<int> { 2, 5, 0 });//5-8
            l.Add(new List<int> { 1, 2, -1 });//5-8-2
            l.Add(new List<int> { 3, 2, -1 });
            l.Add(new List<int> { 3, 1, -1 });
            l.Add(new List<int> { 3, 0, -1 });
            l.Add(new List<int> { 0, 1, -1 });

            ListNode h = solve(l);
            //printing
            while (h != null)
            {               
                Console.WriteLine(h.val);
                h = h.next;
            }
            //            i(1, 226);
            //            i(2, 875);
            //            i(3, 604);
            //            i(4, 550);
            //            i(5, 498);
            //            i(6, 875);
            //            i(7, 847);
            //            i(8, 633);
            //            i(9, 793);
            //            i(10, 872);
            //            i(11, 313);
            //            i(12, 440);
            //            i(13, 331);
            //            i(14, 582);
            //            i(15, 188);
            //            i(16, 476);
            //            i(17, 722);
            //            i(18, 402);
            //            i(19, 890);
            //            i(20, 713);
            //            i(21, 421);
            //            i(22, 930);
            //            i(23, 579);
            //            i(24, 459);
            //            i(25, 278);
            //            i(26, 818);
            //            i(27, 320);
            //            i(28, 549);
            //            i(29, 240);
            //            i(30, 528);
            //            i(31, 367);
            //            i(32, 835);
            //            i(33, 20);
            //            i(34, 170);
            //            i(35, 903);
            //            i(36, 242);
            //            i(37, 943);
            //            i(38, 802);
            //            i(39, 145);
            //            i(40, 291);
            //            i(41, 224);
            //            i(42, 400);
            //            i(43, 43);
            //            i(44, 355);
            //            i(45, 83);
            //            i(46, 26);
            //            i(47, 816);
            //            i(48, 477);
            //            i(49, 425);
            //            i(50, 543);
            //            i(51, 211);
            //            i(52, 799);
            //            i(53, 185);
            //            i(54, 5);
            //            i(55, 184);
            //            i(56, 150);
            //            i(57, 572);
            //            i(58, 626);
            //            i(59, 109);
            //            i(60, 807);
            //            d(25);
            //p();
            //d(53);
            //p();
            //d(12);
            //d(54);
            //p();
            //p();
            //p();
            //p();
            //p();
            //d(39);
            //d(42);
            //p();
            //d(47);
            //d(45);
            //d(35);
            //p();
            //d(13);
            //p();
            //d(18);
            //d(59);
            //d(47);
            //d(43);
            //d(38);
            //p();
            //p();
            //p();
            //p();
            //p();
            //p();
            //d(8);
            //p();
            //d(8);
            //p();
            //d(39);
            //d(60);
            //d(16);
            //p();
            //p();
            Console.ReadLine();
        }

        public static ListNode solve(List<List<int>> A)
        {
            //creating headNode
            ListNode head = null;
            int count = 0;
            for(int i = 0; i < A.Count; i++)
            {
                int op = -2;
                int val = -2;
                int index = -2;
                for(int j = 0; j < 3; j++)
                {
                    //operation
                    if (j == 0)
                        op = A[i][j];
                    else if (j == 1)
                    {
                        if (op == 3)
                            index = A[i][j];
                        else
                            val = A[i][j];
                    }
                    else
                    {   
                        if(op != 3)
                        index = A[i][j];
                    }
                }
                if(op == 0) //at first
                {
                    //create the element
                    ListNode l = new ListNode(val);
                    //insert before the first element
                    if (head == null) //0 length                    
                        head = l;
                    else
                    {
                        l.next = head;
                        head = l;
                    }
                    count++;
                }
                else if(op == 1) //add at last
                {
                    ListNode l = new ListNode(val);
                    if (head == null) //0 length                    
                        head = l;
                    else
                    {
                        ListNode current = head;
                        while (current.next != null)
                        {
                            current = current.next;
                        }
                        //create node 

                        current.next = l;
                    }
                    count++;
                }
                else if(op == 2)
                {
                    //create node
                    ListNode l = new ListNode(val);
                    if (count == 0)
                    {
                        head = l;
                        count++;
                    }
                    else if (count == index)
                    {
                        ListNode current = head;
                        while (current.next != null)
                        {
                            current = current.next;
                        }
                        current.next = l;
                        count++;
                    }
                    else if (count > index)
                    {
                        var c = 0;
                        // 0 1 2 3
                        ListNode current = head;
                        //create node
                        ListNode node = new ListNode(val);
                        if (index == 0)
                        {
                            node.next = head;
                            head = node;
                        }
                        else
                        {
                            while (c != index - 1)
                            {
                                current = current.next;
                                c++;
                            }
                            //create node
                            
                            //add
                            node.next = current.next;
                            current.next = node;
                        }
                        count++;
                    }

                }
                else //delete
                {
                    if(count >= index)
                    {                        
                        if (count == 0 || count == 1)
                            head = null;
                        else
                        {
                            if (index == 0)
                            {
                                head = head.next;
                            }
                            else
                            {
                                var c = 0;
                                ListNode current = head;
                                //traverse till index - 1
                                while (c != index - 1)
                                {
                                    current = current.next;
                                    c++;
                                }
                                current.next = current.next.next;
                            }
                        }                        
                        count--;
                    }    
                        
                }
            }

            //printing
            //while(head.next != null)
            //{
            //    Console.WriteLine(head.val);
            //}
            //Console.ReadLine();
            return head;
        }
        public static void Print(ListNode A)
        {
            while(A.next != null)
            {
                Console.WriteLine(A.val);
            }
        }
        static System.Collections.Generic.List<int> l = new System.Collections.Generic.List<int>();
        public static void i(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            l.Insert(position - 1, value);
        }

        public static void d(int position)
        {
            // @params position, integer
            if (position != 0 && l.Count >= position)
                l.RemoveAt(position - 1);
        }

        public static void p()
        {
            // Output each element followed by a space
            Console.WriteLine(String.Join(" ", l));
        }
    }
}
