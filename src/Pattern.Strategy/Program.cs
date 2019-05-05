using Pattern.Strategy.Choice;
using Pattern.Strategy.Developer;
using Pattern.Strategy.Sort;
using Pattern.Strategy.Sorting;
using System;
using System.Collections.Generic;

namespace Pattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Sort
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nSort");

            SortedList list = new SortedList();
            list.Add("FFF 1");
            list.Add("JJJ 2");
            list.Add("ZZZ 1");
            list.Add("AAA 1");
            list.Add("BBB 1");
            list.Add("DDD 1");
            list.Add("YYY 1");

            list.SetSortStrategy(new Sort.QuickSort());
            list.Sort();

            var sortedList = list.GetSortedList();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Choice
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nChoice");

            IChoice choice;
            Context context = new Context();

            choice = new FirstChoice();
            context.SetChoice(choice);
            context.ShowChoice();

            choice = new SecondChoice();
            context.SetChoice(choice);
            context.ShowChoice();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Developer
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nDeveloper");

            var reports = new List<DeveloperReport>
            {
                new DeveloperReport { Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };


            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");

            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");

            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Sorting
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nSorting");

            ISortingStrategy sortingStrategy = null;
            
            // At first we are sorting by resident name
            List<string> voivodeShipResidence = new List<string> { "ab", "ac", "xa", "td" };
            sortingStrategy = SortingOption.GetSortingOption(ObjectToSort.ResidentName);
            sortingStrategy.Sort(voivodeShipResidence);
            
            // In runtime we are changing algorithm:
            // Sorting by student card number
            List<int> studentNumbers = new List<int> { 123456, 9876543, 345432 };
            sortingStrategy = SortingOption.GetSortingOption(ObjectToSort.StudentAlbumNumber);
            sortingStrategy.Sort(studentNumbers);
            
            // Next algorithm for sorting
            List<string> cityCardNumbers = new List<string> { "A123456", "B9876543", "C345432" };
            sortingStrategy = SortingOption.GetSortingOption(ObjectToSort.CityCardNumber);
            sortingStrategy.Sort(cityCardNumbers);


            Console.ReadKey();
        }
    }
}
