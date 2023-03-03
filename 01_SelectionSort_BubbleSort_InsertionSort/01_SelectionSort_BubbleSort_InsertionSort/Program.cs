using System;

namespace _01_SelectionSort_BubbleSort_InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
			int[] arr = new int[6] { 5, 445, 321, 0, 12, 6 };
            PrintArray(arr);
            SelectionSort(arr);
            PrintArray(arr);
		}

        private static void SelectionSort(int[] arr) // Метод на пряката селекция 
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private static void BibbleSort(int[] arr) // Метод на мехурчето 
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr) // Сортиране, чрез вмъкване 
        {
            int n = arr.Length;

            for (int index = 1; index < n; ++index)
            {
                int key = arr[index];
                int j = index - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}