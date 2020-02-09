using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMoshPart3
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            bool isSorted;
            for (int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for (int j = 1; i < array.Length-i; j++)
                    if (array[j] < array[j - 1])
                    {
                        swap(array,j,j-1);
                        isSorted = false;
                    }
                if (isSorted)
                    return;
            }
        }

        private void swap(int[] array, int index1,int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
