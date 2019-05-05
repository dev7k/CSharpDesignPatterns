namespace Pattern.Strategy.Sorting
{
    public static class SortingOption
    {
        public static ISortingStrategy GetSortingOption(ObjectToSort objectToSort)
        {
            ISortingStrategy sortingStrategy = null;
            // Base on input data we are choosing different algorithm for sorting
            // In runtime we can change sorting algorithm 

            switch (objectToSort)
            {
                case ObjectToSort.StudentAlbumNumber:
                    sortingStrategy = new MergeSort();
                    break;
                case ObjectToSort.CityCardNumber:
                    sortingStrategy = new HeapSort();
                    break;
                case ObjectToSort.ResidentName:
                    sortingStrategy = new QuickSort();
                    break;
                default:
                    break;
            }

            return sortingStrategy;
        }
    }
}
