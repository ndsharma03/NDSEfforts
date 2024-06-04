namespace APIVersioningTest
{
    public class Program
    {

        public static void MergeAndSort_UnSoretedArray()
        {
            //trying to merge and sort two unsorted array.
            //first merge two array
            //Sort merged array

            int[] a = { 3, 4, 77, 5, 6 };
            int[] b = { 1, 4, 66, 9 };
           
            int[] c = new int[a.Length + b.Length];
            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);

            Console.WriteLine("Merged array without sorting");
          //  foreach (var item in c) { Console.WriteLine(item); } //Prinintg
            int temp = 0;
            for (int i= 0;i < c.Length; i++){
                for(int j = i + 1; j < c.Length; j++) {

                    if (c[i] >= c[j]) {
                        temp = c[j];
                        c[j] = c[i];
                        c[i] = temp;
                    }
                }
            }
            foreach (var item in c) { Console.WriteLine(item); }
        }
        public static void MergeTwoSortedArray()
        {
            // program to merge two sorted arrays

            int[] a = { 3, 4, 77, 5,6 };
            int[] b = { 1, 4, 66, 68 };
            int a_length= a.Length, b_length= b.Length;
            int counter_a = 0, counter_b = 0, counter_new = 0;
            int[] c = new int[a_length + b_length];
            while(counter_a<a_length && counter_b < b_length)
            {
                if (a[counter_a]> b[counter_b])
                {
                    c[counter_new++] = b[counter_b++];

                }
                else
                {
                    c[counter_new++] = a[counter_a++];
                }
            }
            Console.WriteLine(  $"value of counter new has been reached at { counter_new}");
            while (counter_a < a_length)
            {
                c[counter_new++] = a[counter_a++];
            }
            while (counter_b < b_length)
            {
                c[counter_new++] = b[counter_b++];
            }
            Console.WriteLine(  "Values of merged array :");
            foreach (var item in c) { Console.WriteLine( item); }
        }
        public static void Main(string[] args)
        {
            MergeAndSort_UnSoretedArray();
           // MergeTwoSortedArray();

            var builder = WebApplication.CreateBuilder(args);
	}
	
}
}