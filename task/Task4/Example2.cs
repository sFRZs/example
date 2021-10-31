using System;

namespace Task4._2
{
    class Example2
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int[] ArrayA = new int[20];
            Random randA = new Random();
            Console.WriteLine("Random array A");
            for (int x = 0; x < ArrayA.Length; x++)
            {
                ArrayA[x] = randA.Next(100);
                Console.WriteLine("Element["+x+"]:"+ ArrayA[x]);
            }
            int temp;
            for (int i = 0; i < ArrayA.Length - 1; i++)
            {
                for (int j = i + 1; j < ArrayA.Length; j++)
                {
                    if (ArrayA[i] > ArrayA[j])
                    {
                        temp = ArrayA[i];
                        ArrayA[i] = ArrayA[j];
                        ArrayA[j] = temp;
                    }
                }
            }
            Console.WriteLine("Output of a sorted array");
            for (int i = 0; i < ArrayA.Length; i++)
            {
                Console.WriteLine("Element["+i+"]:"+ ArrayA[i]);
            }

            int min = ArrayA[0];
            
            for (int i = 0; i < ArrayA.Length; i++)
                if (ArrayA[i] < min)
                {
                    min = ArrayA[i];
                  
                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Element min " + min);

            int max = ArrayA[0];
            for (int i = 0; i < ArrayA.Length; i++)
                if (ArrayA[i]>  max)
                {
                    max = ArrayA[i];
                    
                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Element max " + max);
            /*   for (int i = Math.Min(max, min)+1 ; i < Math.Max(max, min); i++)
                {
                    Console.WriteLine(i);
                    sum +=ArrayA[i]; 
                }
          foreach (int i in ArrayA)
                  Console.Write(i + " ");*/
            
            for (int i = 0; i < ArrayA.Length; i++)
            {
                if (max > min && (i - 1) < max)
                {
                    sum += ArrayA[i];
                }
                if (max < min && (i - 1) < min)
                {
                    sum += ArrayA[i + 1];
                }
            }
            int sum1 = (min + max);
            int sum2 = sum - sum1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sum all elements: " + sum);
            Console.WriteLine("Sum max and min : " + sum1);
            Console.WriteLine("Sum between the maximum and minimum: " + sum2);
        }
    }
}
