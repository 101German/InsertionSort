using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {
        static IList<T> Sort<T>(IList<T> container) where T : IComparable<T>
        {
            for (int i = 1; i < container.Count; i++)
            {
                int j = i;

                while ((j > 0) && (container[j - 1].CompareTo(container[j]) > 0))
                {
                    var temp = container[j];
                    container[j-1] = container[j];
                    container[j] = temp;

                    j--;
                }



            }

            return container;


        }

    }
}
