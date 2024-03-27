//Write a C# program to reverse element of an array.

using System;

namespace ArrayReverse
{
    class q3
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            ReverseArray(arr);

            Console.WriteLine("\nReversed Array:");
            PrintArray(arr);
        }


        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;


                start++;
                end--;
            }
        }


        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
