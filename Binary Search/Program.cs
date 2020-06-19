using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our Array Contains: ");

            Array.ForEach(array, x => Console.WriteLine(x + " "));

            Console.WriteLine($"\n\n The result of a binary search for {theValue} is: ");
            Console.WriteLine(binarySearch(array, theValue));

        }

        //Quick summary of the represetation
        /*
         * a = array
         * x = what is been searched
         * p = first index
         * q = midpoint
         * r = last index
         */
        public static int binarySearch(int[] a, int x)
        {

            //Initilize the variable
            int p = 0; //beginning of the range
            int r = a.Length - 1; //the end of the array

            //search for our value
            while (p <= r) //When true we are still looping
            {
                int q = (p + r) / 2; //find the midpoint
                if (x < a[q])
                    r = q - 1;
                else if (x > a[q])
                    p = q + 1;

                else return q;
            }

            //case the value is not found
            return -1;
        }
    }

}
