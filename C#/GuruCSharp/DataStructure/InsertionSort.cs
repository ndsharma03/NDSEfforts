using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.DataStructure
{
    class InsertionSort
    {

        //public static void Main()
        //{
        //    int[] unSoredArray = new int[] { 4, 2, 3, 6, 9, 1, 2 };

        //    for (int i = 0; i <= unSoredArray.Length - 1; i++)
        //    {
        //        int val = unSoredArray[i];//4
        //        int j = i ;
        //        while(j>0 && unSoredArray[j-1] >val)//4- 2,2-4
        //        {
        //            unSoredArray[j] = unSoredArray[j-1];
        //            j--;
        //        }
        //        unSoredArray[j] = val;
        //    }
        //    PrintArray(unSoredArray);
        //    Console.Read();
        //}
        public static void PrintArray(int[] unSoretedArray)
        {
            foreach (int i in unSoretedArray)
            {
                Console.Write($" {i}  ");
            }
            Console.WriteLine();
        }
    }
}
