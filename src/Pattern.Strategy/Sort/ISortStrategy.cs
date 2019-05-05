using System.Collections.Generic;

namespace Pattern.Strategy.Sort
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
