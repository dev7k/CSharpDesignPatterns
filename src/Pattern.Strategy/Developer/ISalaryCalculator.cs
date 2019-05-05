using System.Collections.Generic;

namespace Pattern.Strategy.Developer
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
