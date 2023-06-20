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
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();

        }

    }
}