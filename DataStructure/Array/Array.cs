using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public class ArrayOperations
    {

        /* utility function to print an array */
        internal static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        internal static void MoveLeft(int[] arr, int n, int d)
        {
            for (int i = 0; i < d; i++)
                MoveArrayLeftByOne(arr, n);           
        }

        internal static void MoveArrayLeftByOne(int [] arr,int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            arr[i] = temp;
        }

        internal static void ArrayRotation()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            MoveLeft(arr, 7, 2);
            printArray(arr, 7);
            Console.ReadKey();
        }
    }
}
