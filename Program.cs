using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 3, 5, 9, 12};
            int item_to_find = 5;

            if(BinarySearch(arr, 0, arr.Length - 1, item_to_find) != -1)
            {
                Console.WriteLine("Item found");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            Console.ReadLine();

        }

        static int BinarySearch(int[] arr, int left, int right, int item_to_find)
        {
            if(left <= right)
            {
                int middle = (left + right)/2;

                if(arr[middle] == item_to_find)
                {
                    return item_to_find;
                }

                if(arr[middle] > item_to_find)
                {
                    return BinarySearch(arr, left, middle-1, item_to_find);
                }
                else
                {
                    return BinarySearch(arr, middle +1, right, item_to_find);
                }
               
            }
            return -1;
        }
    }
}
