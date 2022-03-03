using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Arrays_Program
{
    internal class Program
    {
        static void Result(int[] arr)
        {

            // displaying the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array Element: " + arr[i]);
            }
        }
        static void Main()
        {
            // declaring an array
            // and initializing it
            int[] arr = { 10, 652, 122, 74, 69 };

            // calling the method
            Result(arr);
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
