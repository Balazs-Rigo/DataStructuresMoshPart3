using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMoshPart3
{
    public class SelectionSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                for (int j = i; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                swap(array,minIndex,i);    
            }
        }
        private void swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
                
    }
}
