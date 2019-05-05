using System.Linq;
using Xunit;

namespace Pattern.Strategy.Tests.Sort
{
    public class QuickSort
    {
        [Fact]
        public void check_quick_sort()
        {
            // Arrange
            Strategy.Sort.SortedList list = new Strategy.Sort.SortedList();
            list.Add("DDD 1");
            list.Add("ZZZ 1");
            list.Add("ZZZ 2");
            list.Add("GGG 1");
            list.Add("AAA 1");
            list.Add("YYY 1");

            // Act
            list.SetSortStrategy(new Strategy.Sort.QuickSort());
            list.Sort();

            var expectedFirstElement = "AAA 1";
            var expectedLastElement = "ZZZ 2";
            var sortedList = list.GetSortedList();
            var firstElement = sortedList.First();
            var lastElement = sortedList.Last();

            // Assert
            Assert.Equal(expectedFirstElement, firstElement);
            Assert.Equal(expectedLastElement, lastElement);
        }
    }
}
