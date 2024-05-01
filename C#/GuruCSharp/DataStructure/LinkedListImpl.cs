using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.DataStructure
{
    //struct Node
    //{
    //    int data;
    //    Node Next;
    //}
    class LinkedListImpl
    {
        Node temp, head,last;
        int count = 0;
        public void InsertAtEnd(int value)
        {
            temp = new Node() { data = value, Next = null };
            if (head == null)
            {
                head = temp;
                last = temp;
            }
            
            last.Next = temp;
            last = temp;
            
            count++;
        }
        public void PrintLinkedList()
        {
            temp = head;
            if (temp == null) throw new Exception("Empty linked list!");

            while (temp != null) 
            {
                Console.Write($"{temp.data}=>");
                temp = temp.Next;
            }

            Console.WriteLine("First element of List is " + head.data);
            Console.WriteLine("Last element of List is " + last.data);
        }
        public void InsertAtStart(int value)
        {
            temp = new Node() { data = value, Next = head };
            head = temp;

        }
        public void Insert(int insertAfter,int value)
        {
            temp = head;
            while (temp != null)
            {
                if (temp.data == insertAfter)
                {
                    Node temp2 = new Node { data = value, Next = temp.Next };
                    temp.Next = temp2;

                    // if inserted at last then need to Move last pointer.
                    if (temp2.Next is null)
                    {
                        last = temp2;
                    }
                    break;
                    
                }
                temp = temp.Next;
            }
        }

        public bool Find(int value)
        {
            temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                
                temp = temp.Next;
            }
            return false;
        }
        public bool Delete(int value)
        {
            if (head.data == value)// if data is available at head node
            {
                head = head.Next;
                return true;
            }
            temp = head;
            while (temp != null)// moving till( desired node -1). i.e. before the desired node (1=>2=>5=>6=>7=>8 and we want to delete 6, so need to move till 5 th only.)
            {
               
                if (temp.Next?.data == value)
                {
                    temp.Next = temp.Next.Next;
                }

                if (temp.Next is null)// to set last node.
                {
                    last = temp;
                }
                temp = temp.Next;
                
            }
            return false;
        }
        class Node
        {
            public int data { get; set; }
            public Node Next { get; set; }
        }
/*
        public static void Main()
        {
            LinkedListImpl linkedList = new LinkedListImpl();

            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(6);

            linkedList.InsertAtStart(1);
            linkedList.InsertAtStart(0);

            linkedList.Insert(4, 5);
            linkedList.Insert(6, 7);
            linkedList.Insert(7, 8);


            Console.WriteLine(linkedList.Find(3));
            Console.WriteLine(linkedList.Find(0));
            Console.WriteLine(linkedList.Find(7));

            linkedList.PrintLinkedList();
            linkedList.Delete(7);
            linkedList.Delete(0);
            linkedList.Delete(8);
            linkedList.PrintLinkedList();
            Console.Read();

        }
        */
    }
}
