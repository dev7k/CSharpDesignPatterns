using System.Collections.Generic;
using System.Linq;

namespace Pattern.Strategy.Developer
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
        {
            return reports.Where(r => r.Level == DeveloperLevel.Senior)
                          .Select(r => r.CalculateSalary() * 1.2)
                          .Sum();
        }
    }
}
