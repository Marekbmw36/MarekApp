
using ConsoleApp4;

var employee = new Employee("Paweł", "Kowalski", 28);
employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(8);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: + { statistics.Average:N2}");
Console.WriteLine($"Min: + {statistics.Min}");
Console.WriteLine($"Max: + {statistics.Max}");

