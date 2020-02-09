using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMoshPart3
{
    public class Search
    {
        public int LinearSearch(int[] array, int target)
        {
            for (var i = 0; i < array.Length; i++)
                if (array[i] == target)
                    return i;

            return -1;
        }
    }
}
