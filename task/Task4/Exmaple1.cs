using System;
using System.Linq;

namespace Task4._1
{
    class Exmaple1
    {
        static int[] ConcatArrays(int[] ArrayA, int[] ArrayB)
        {
            int[] ArrayC = new int[ArrayA.Length + ArrayB.Length];////the length of the resulting array is equal to the sum of the lengths of the original arrays
            for (int i = 0; i < ArrayA.Length; i++)//transferring numbers from array A to mass C

                ArrayC[i] = ArrayA[i];

            for (int i = ArrayA.Length; i < ArrayA.Length + ArrayB.Length; i++)//we transfer numbers from array B to mass C, starting from index ArrayA.Length

                ArrayC[i] = ArrayB[i - ArrayA.Length];
            return ArrayC;

        }
        static void Main(string[] args)
        {
            int[] ArrayA = new int[5];
            Random randA = new Random();
            Console.WriteLine("Random array A");
            for (int x = 0; x < ArrayA.Length; x++)
            {
                ArrayA[x] = randA.Next(20);
                Console.WriteLine(ArrayA[x]);
            }
            int[] ArrayB = new int[5];
            Random randB = new Random();
            Console.WriteLine("Random array B");
            for (int y = 0; y < ArrayA.Length; y++)
            {
                ArrayB[y] = randB.Next(20);
                Console.WriteLine(ArrayB[y]);
            }
            int[] ArrayC = ConcatArrays(ArrayA, ArrayB);

            int temp;// sort in ascending order ArrayC
            for (int i=0; i < ArrayC.Length - 1; i++)
            {
                for (int j = i + 1; j < ArrayC.Length; j++)
                {
                    if (ArrayC[i] > ArrayC[j])
                    {
                        temp = ArrayC[i];
                        ArrayC[i] = ArrayC[j];
                        ArrayC[j] = temp;
                    }
                }
            }
            Console.WriteLine("array A to join with array B ");
            foreach (int i in ArrayC)
                Console.WriteLine($"{i}");
        }
    }
}
