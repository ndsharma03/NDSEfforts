using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.DataStructure
{
    class SelectionSort
    {
        /// <summary>
        /// Selection Sort : 
        //We will consider that at the first position element in array is minium, and then serach in entire array smaller than
        // selected min we will exachange the array element( for ex: at first itiration we consider that 0th element is min. if any other let's say 3rd element 
        // is smaller then min.then we will exchange element of 0 and 3.now we have smallest elemnt of array at oth position.similiarly we will do for first element and otehr in array.
        ///// 
        /// </summary>
        //public static void Main()
        //{
        //    int[] unSoretedArray = new int[] { 1,8,6,4,4,2,5 };
        //    PrintArray(unSoretedArray);
        //    for (int i = 0; i <= unSoretedArray.Length-2; i++)
        //    {
        //        int min = unSoretedArray[i];
                
        //        int indexOfMin = i;
        //        for (int j = i+1; j <= unSoretedArray.Length - 1; j++)
        //        {
                    
        //            if (min > unSoretedArray[j])
        //            {
        //                min = unSoretedArray[j];                           
        //                indexOfMin = j;
                        
        //            }
        //        }
        //        unSoretedArray[indexOfMin] = unSoretedArray[i];
        //        unSoretedArray[i] = min;

        //        Console.Write("                                                                          ");
        //        PrintArray(unSoretedArray);
        //        Console.WriteLine($"Changing position of elements from {indexOfMin} to {i}");

        //    }
            
        //    Console.Read();
        //}
        public static void PrintArray(int [] unSoretedArray)
        {
            foreach (int i in unSoretedArray)
            {
                Console.Write($" {i}  " );
            }
            Console.WriteLine();
        }
    }
}
