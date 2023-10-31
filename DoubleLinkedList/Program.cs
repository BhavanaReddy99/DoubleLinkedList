using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {

        static void Main(string[] args)
        {
            runApp();
        }

        static int CalculateLength(DoubleLinkedList list)
        {
            int length = 0;
            Node current = list.Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }
        static void runApp()
        {
            DoubleLinkedList list = new DoubleLinkedList();

            // Add elements to the doubly linked list using a for loop
            for (int i = 10; i <= 20; i++)
            {
                list.Add(i);
            }


            // Calculate and display the length of the list
            int length = CalculateLength(list);
            Console.WriteLine("Length of the Doubly Linked List: " + length);
            // Display the doubly linked list
            Console.WriteLine("Doubly Linked List Elements:");
            list.Display();

            
           
        }

       

    }

}
    