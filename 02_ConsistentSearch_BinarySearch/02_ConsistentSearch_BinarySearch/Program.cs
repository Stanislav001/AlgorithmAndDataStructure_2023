using System;

namespace _02_ConsistentSearch_BinarySearch
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 2, 4, 6, 10, 50, 21, 13 };

            Console.WriteLine("ConsistentSearch Results: ");
            Console.WriteLine($"Is exist {ConsistentSearch(array, 3)}");
            Console.WriteLine($"Is exist {ConsistentSearch(array, 13)}");

            Console.WriteLine("=================");
            Console.WriteLine("BinarySearch Results: ");
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine($"Is exist {BinarySearch(sortedArray, 0)}");  
            Console.WriteLine($"Is exist {BinarySearch(sortedArray, 1)}");
        }

        private static bool ConsistentSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middleElement = (left + right) / 2;

                if (array[middleElement] == key)
                {
                    return true;
                }
                else
                {
                    if (array[middleElement] < key)
                    {
                        left = middleElement + 1;
                    }
                    else
                    {
                        right = middleElement - 1;
                    }
                }
            }
            return false;
        }
    }
}