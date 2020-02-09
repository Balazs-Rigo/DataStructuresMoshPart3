using System;

namespace DataStructuresMoshPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12,32,7,0,1,999,1,66,31,44,};

            var bubbleSort = new BubbleSort();
            var selectionSort = new SelectionSort();
            var insertSort = new InsertionSort();
            var mergeSort = new MergeSort();
            var quickSort = new QuickSort();
            var countingSort = new CountingSort();
            var bucketSort = new BucketSort();

            foreach (int item in array)
            {
                Console.Write(item + " ;");
            }

            Console.WriteLine();            

            bucketSort.Sort(array,5);

            foreach (int item in array)
            {
                Console.Write(item+" ;");
            }

            Console.ReadLine();
        }
    }
}
