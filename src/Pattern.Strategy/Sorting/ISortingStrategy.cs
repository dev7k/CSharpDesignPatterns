using System.Collections.Generic;

namespace Pattern.Strategy.Sorting
{
    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToSort);
    }
}
