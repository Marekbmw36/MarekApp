
using ConsoleApp4;

var employee = new Employee("Paweł", "Kowalski");
employee.AddGrade("Paweł");
employee.AddGrade("5000");
employee.AddGrade(6);
employee.AddGrade(8);
employee.AddGrade(7);


var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWitchForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Sum: {statistics.Sum}");

Console.WriteLine($"GetStatisticsWitchForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Sum: {statistics1.Sum}");

Console.WriteLine($"GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Sum: {statistics2.Sum}");

Console.WriteLine($"GetStatisticsWithDoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Sum: {statistics3.Sum}");

Console.WriteLine($"GetStatisticsWithWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Sum: {statistics4.Sum}");



