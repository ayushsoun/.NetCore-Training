using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11May
{
    //Represent a node of the doubly linked list  
    internal class BookShopNode<T>
    {
        public T data;
        public BookShopNode<T> previous;
        public BookShopNode<T> next;

        public BookShopNode(T value)
        {
            data = value;
        }

      
        public class DoublyBookList<T>
        {
            //Represent the head and tail of the doubly linked list  
            protected BookShopNode<T> head = null;
            protected BookShopNode<T> tail = null;

            //addBook() will add a node to the list 
            public void AddBook(T book)
            {
                //Create a new node 
                BookShopNode<T> newbook = new BookShopNode<T>(book);

                //if list is empty
                if(head == null) 
                {
                    //Both head and tail will point to newNode  
                    head = tail = newbook;

                    //head's previous will point to null
                    head.previous = null;

                    //tail's next will point to null
                    tail.next = null;
                }
                else
                {
                    //new node will be added after tail such that tail's next will point to new node
                    tail.next = newbook;
                    //newNode's previous will point to tail  
                    newbook.previous = tail;
                    //newNode will become new tail 
                    tail = newbook;
                    //As it is last node, tail's next will point to null 
                    tail.next = null;
                }
            }

            public void Display()
            {
                //Node current will point to head
                BookShopNode<T>current = head;

                if(head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                Console.WriteLine("Nodes of doubly linked list are-: ");
                while(current!= null)
                {
                    Console.WriteLine(current.data + " ");
                    current = current.next;
                }
            }
        }
    }
}
