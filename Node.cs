using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Node
    {
      int data;
        Node next;
        public Node(int data)
        {
            this.data = data;
          // Console.Write("inserted using node:"+ data);
            // Console.ReadLine();
        }
        static void insert(int value,Node head,int pos)
        {
            Node toAdd = new Node(value);
            if(pos==0)
            {
                toAdd.next = head;
            }
            Node prev = head;
            for(int i=0;i<pos-1;i++)
            {
                prev = prev.next;
            }
            toAdd.next = prev.next;
            prev.next = toAdd;
        }
        static void diaplay(Node head)
        {
            Node cur = head;
            if(cur==null)
            {
                Console.WriteLine("linkedlist is empty");
            }
            
            while (cur!=null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
            Console.ReadLine();
        }
      //  bool contains = Node.contains(6);
      
      /*  public static void Main()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(4);
            Node head = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = null;
            insert(3, head, 2);
            diaplay(head);
           // bool dfsdf = Node.contains(6);
        }*/
        public class LinkedListStack
        {
            Node top;
            public LinkedListStack()
            {
                this.top = null;
            }
            public void Push(int value)
            {
                Node newNode = new Node(value);
                if (top == null)
                {
                    newNode.next = null;
                }
                if(top!=null)
                {
                    newNode.next = top;
                }
                 top = newNode;
                Console.Write($"pushed to stack,{value}");
                Console.ReadLine();
            }
            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("stack underflow:deletion not possible");
                    return;
                }
                
                
                    Console.WriteLine($"item is popped, {top.data}");
                    top = top.next;
                    Console.ReadLine();
                    
                
            }
            public void Display()
            {
                Node temp = this.top;
                
                while(temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
               
                Console.ReadLine();
            }
            void isEmpty()
            {
                
                while(this.top!=null)
                {
                    Pop();
                }
            }

              /*  public static void Main()
              {
                  LinkedListStack stack = new LinkedListStack();
                  stack.Push(5);
                  stack.Push(4);
                  stack.Push(3);
                  stack.Push(2);
                  stack.Push(1);
                 // stack.Pop();
                  stack.Display();
                  stack.isEmpty();
               // bool dg = LinkedListStack.contains(7);
              }*/
            //----------------------------------------------------------------------------------------------
           public class LinkedListQueue
            {
                Node front;
                Node rear;
                public LinkedListQueue()
                {
                    rear = null;
                    front = null;
                }
                public void Enqueue(int item)
                {
                    Node newNode = new Node(item);
                    if (rear == null)
                    {
                        front = rear = newNode;
                    }
                    if(rear!=null)
                    {
                        rear.next = newNode;
                    }
                    rear = newNode;
                    Console.Write($" inserted into Queue,{item}");
                    Console.ReadLine();
                }
                public void Dequeue()
                {
                    if (front == null)
                    {
                        Console.WriteLine("the queue is empty");
                        return;
                    }

                   // Node temp = front;
                    
                        Console.WriteLine($"item deleted from queue,{front.data}");
                        front = front.next;
                   
                    Console.ReadLine();
                }
                void Display()
                {
                    if (front == null)
                    {
                        Console.WriteLine("the queue is empty");
                        Console.ReadLine();
                        return;
                    }
                    Node temp = front;
                    while(temp!=null)
                    {
                        Console.WriteLine(temp.data);
                        temp = temp.next;
                    }
                    Console.Read();
                }
              /* public static void Main()
                {
                    LinkedListQueue l = new LinkedListQueue();
                    l.Enqueue(1);
                    l.Enqueue(2);
                    l.Enqueue(3);
                    l.Enqueue(4);
                    l.Enqueue(5);
                   l.Dequeue();
                    l.Dequeue();
                    l.Dequeue();
                    l.Dequeue();
                    l.Dequeue();
                    l.Display();
                }*/
            }
        }
    }
}
