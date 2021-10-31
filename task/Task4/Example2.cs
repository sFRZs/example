using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4._2
{
    class Example2
    {
        static void Main(string[] args)
        {

            //example with a queue
            int sum = 0;
            int summa = 0;
            int summa3 = 0;
            int[] arr = Enumerable.Range(1, 25).ToArray();
            Console.WriteLine("Queue");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            int min1 = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < min1)
                {
                    min1 = arr[i];

                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Element min " + min1);

            int max1 = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max1)
                {
                    max1 = arr[i];

                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Element max " + max1);
            for (int i = 0; i < arr.Length; i++)
            {
                if (max1 > min1 && (i - 1) < max1)
                {
                    summa += arr[i];
                }
                if (max1 < min1 && (i - 1) < min1)
                {
                    summa += arr[i + 1];
                }
            }
            int summa1 = (min1 + max1);
            int summa2 = summa - summa1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sum all elements: " + summa);
            Console.WriteLine("Sum max and min : " + summa1);
            Console.WriteLine("Sum between the maximum and minimum: " + summa2);
            Console.WriteLine("---------------------------------------------------------");
            /*for (int i = Math.Min(min1, max1); i < Math.Max(min1, max1); i++)
            {
                summa3+= arr[i];
            }
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine("Сумма: " + summa3);
            Console.WriteLine("----------------------------------------------------------");*/

            //example with a random
            Console.ForegroundColor = ConsoleColor.Gray;
            int[] ArrayA = new int[20];
            Random randA = new Random();
            Console.WriteLine("Random array A");
            for (int x = 0; x < ArrayA.Length; x++)
            {
                ArrayA[x] = randA.Next(100);
                Console.WriteLine("Element[" + x + "]:" + ArrayA[x]);
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
                Console.WriteLine("Element[" + i + "]:" + ArrayA[i]);
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
                if (ArrayA[i] > max)
                {
                    max = ArrayA[i];

                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Element max " + max);
 
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


