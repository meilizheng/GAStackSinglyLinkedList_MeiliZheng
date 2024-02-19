using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Meili Zheng 2/19/2024

namespace GAStackSinglyLinkedList_MeiliZheng
{
    public class Stack<T>
    {
        //nested class 
        class StackNode<T>
        {
            //Property
            public T value { get; set; }
            public StackNode<T> Next { get; set; }

            //Constructor 
            public StackNode(T value)
            {
                this.value = value;
                Next = null;
            }
        }

        //Field
        private StackNode<T> top;
        private int count;
        //Property
        public int Count
        {
            get { return count; }
        }
        
        //Constructor
        public Stack()
        {
            //assign the value
            top = null;
            count = 0;
        }

        //Push Method
        public void push(T value)
        {
            StackNode<T> node = new StackNode<T>(value);
            node.Next = top;
            top = node;
            count++;
        }

        //Pop Method
        public T Pop()
        {
            if (top == null)// If stack is empty
            {
                throw new InvalidOperationException("Stack is empty.");// Throw an exception
            }
            T value = top.value;// Get the value of the top node
            top = top.Next;// Update top to point to the next node
            count--;// Decrement the count of elements
            return value;// Return the value of the removed node
        }

        //Peek Method
        public T Peek()
        {
            if(top == null)// If stack is empty
            {
                throw new InvalidOperationException("Stack is empty.");// Throw an exception
            }
            Console.WriteLine(top.value);// Print the value of the top node
            return top.value;// Return the value of the top node
        }

        //Clear Method
        public void Clear()
        {
            //Run until the stack is empty
            while(top != null)
            {
                //Store the reference to the next node
                StackNode<T> nextNode = top.Next;
                //Remove the top node from the stack
                top = null;
                //Move to the next node
                top = nextNode;
                //Decrement the count
                count--;
            }
        }

        //Print result method
        public void printResult()
        {
            if (top != null)// If stack is not empty
            {
                StackNode<T> current = top;// Start from the top node
                while (current != null)// Iterate until reaching the end of the stack
                {
                    Console.WriteLine(current.value);// Print the value of the current node
                    current = current.Next;// Move to the next node
                }
            }
        }
    }
}

