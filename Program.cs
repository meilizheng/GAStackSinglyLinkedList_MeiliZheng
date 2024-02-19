namespace GAStackSinglyLinkedList_MeiliZheng
{
    //Meili Zheng 2/19/2024
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //Add elements
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            //Print elements
            Console.WriteLine("Print elements:");
            stack.printResult();
            //Pop elements
            stack.Pop();
            stack.Pop();
            Console.WriteLine("=================================");
            //peek element
            Console.WriteLine("Peek elements");
            stack.Peek();

        }
    }
}