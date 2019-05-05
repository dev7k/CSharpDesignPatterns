using System;
using System.Collections.Generic;

namespace Pattern.Strategy.Sort
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private ISortStrategy _sortstrategy;

        public void SetSortStrategy(ISortStrategy sortstrategy)
        {
            _sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);
        }

        public List<string> GetSortedList()
        {
            return _list;
        }
    }
}
