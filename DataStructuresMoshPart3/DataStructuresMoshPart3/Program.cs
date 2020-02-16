using System;

namespace DataStructuresMoshPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region part1-2
            /*
            int[] array = new int[] { 12,32,7,0,1,999,1,66,31,44,};

            var bubbleSort = new BubbleSort();
            var selectionSort = new SelectionSort();
            var insertSort = new InsertionSort();
            var mergeSort = new MergeSort();
            var quickSort = new QuickSort();
            var countingSort = new CountingSort();
            var bucketSort = new BucketSort();
            var search = new Search();

            foreach (int item in array)
            {
                Console.Write(item + " ;");
            }

            Console.WriteLine();

            quickSort.Sort(array);            

            foreach (int item in array)
            {
                Console.Write(item+" ;");
            }
            Console.WriteLine();
            Console.WriteLine(search.ExponentialSearch(array,30));
            */
            #endregion
           

            #region part3

            int count = StringUtils.CountVowels("Ugyesmokus Buszkemacko");
            Console.WriteLine(count);

            string reversed = StringUtils.Reverse("ugyesmokus buszkemacko");
            Console.WriteLine(reversed);

            Console.WriteLine(StringUtils.ReverseWords("Ugyesmokus buszkemacko telkesmokus jogasmacko"));
            Console.WriteLine(StringUtils.AreRotations("ABCD","ACDB"));
            Console.WriteLine(StringUtils.RemoveDuplicates("Ugyesmokus buszkemacko"));
            Console.WriteLine(StringUtils.Capitalize("today is a great day ugyesmokus buszkemacko"));
            Console.WriteLine(StringUtils.AreAnagrams("ugyesmokus","mokusugyes")) ;
            Console.WriteLine("Is palindrome: "+StringUtils.IsPalindrome("inulagoogaludni"));
            #endregion
            Console.ReadLine();
        }
    }
}
