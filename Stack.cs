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
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T value = top.value;
            top = top.Next;
            count--;
            return value;
        }

        //Peek Method
        public T Peek()
        {
            if(top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            Console.WriteLine(top.value);
            return top.value;
        }

        //Clear Method
        public void Clear()
        {
            top = null;
            count = 0;
        }

        //Print result method
        public void printResult()
        {
            if (top != null)
            {
                StackNode<T> current = top;
                while (current != null)
                {
                    Console.WriteLine(current.value);
                    current = current.Next;
                }
            }
        }
    }
}

