using System;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");
            Code obj = new Code();
            obj.Enqueue(70);
            obj.Enqueue(30);
            obj.Enqueue(56);

            Console.WriteLine("Element stored in queue is:-");
            obj.Display();
            Console.WriteLine("After Dequeue operation:");
            obj.Dequeue();
            Console.WriteLine("Element stored in queue is:-");
            obj.Display();

        }

    }
}