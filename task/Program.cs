using System;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1 
            Console.WriteLine("example 1:");
            bool boolValue = true;
            byte byteValue = 55;
            sbyte sbyteValue = -1;
            short shortValue = -1000;
            ushort ushValue = 25555;
            int intValue = 265;
            float floatValue = 12.3f;
            double doubelValue = 12.3;
            Console.WriteLine($"Your data: {boolValue}\t {byteValue}\t {sbyteValue}\t{shortValue}\t{ushValue}\t{intValue}\t{floatValue}\t{doubelValue}\n");
            //-----------------------------------------------------------------------------------
            Console.Write("example 2: \n");
            Console.Write("Enter an integer x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer y=");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer z=");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integerо t=");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Select * or / or + or - or for example: ({x}?{y})*({z}?{t})");
            string example = Console.ReadLine();
            switch (example)
            {
                case "*":
                    int a = (x * y) * (z * t);
                    Console.WriteLine($"You have chosen *:  ({x}*{y})*({z}*{t})= {a}");
                    break;
                case "/":
                    int a2 = (x / y) * (z / t);
                    Console.WriteLine($"You have chosen /:  ({x}/{y})*({z}/{t})= {a2}");
                    break;
                case "+":
                    int a3 = (x + y) * (z + t);
                    Console.WriteLine($"You have chosen +:  ({x}+{y})*({z}+{t})= {a3}");
                    break;
                case "-":
                    int a4 = (x - y) * (z - t);
                    Console.WriteLine($"You have chosen -:  ({x}-{y})*({z}-{t})= {a4}");
                    break;
                default:
                    Console.WriteLine("You have chosen an unknown action");
                    break;
            }
            Console.ReadKey();
        }
    }
}
