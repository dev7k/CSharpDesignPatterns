using System.Collections.Generic;

namespace Pattern.Strategy.Sorting
{
    public class QuickSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToSort)
        {
            dataToSort.Sort();
        }
    }
}
