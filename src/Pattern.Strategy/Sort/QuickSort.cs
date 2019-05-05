using System.Collections.Generic;

namespace Pattern.Strategy.Sort
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
