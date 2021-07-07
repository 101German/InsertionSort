using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {
        static IList<T> Sort<T>(IList<T> array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Count; i++)
            {
                int j = i;

                while ((j > 0) && (array[j - 1].CompareTo(array[j]) > 0))
                {
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    j--;
                }



            }

            return array;


        }

    }
}
