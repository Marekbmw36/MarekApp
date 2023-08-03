

using ConsoleApp3;
using System;

Employee employee1 = new Employee("Piotr","Nowak",27);
Employee employee2 = new Employee("Michał","Kowalski",33);
Employee employee3 = new Employee("Łukasz","Zdanewicz",24);

employee1.Addscore(5);
employee1.Addscore(4);
employee1.Addscore(1);
employee1.Addscore(6);
employee1.Addscore(5);

employee2.Addscore(5);
employee2.Addscore(7);
employee2.Addscore(5);
employee2.Addscore(9);
employee2.Addscore(3);

employee3.Addscore(5);
employee3.Addscore(3);
employee3.Addscore(2);
employee3.Addscore(5);
employee3.Addscore(4);


List<Employee> employees = new List<Employee>()
{
   employee1 ,employee2 , employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }

}
Console.WriteLine("Pracownik " +  employeeWithMaxResult.Name + " " +  "" + employeeWithMaxResult.Surname +  " " + "" + ( employeeWithMaxResult.Age +  "lat: ") +  "" + "uzyskał największą liczbę ocen " + "" +  employeeWithMaxResult.Result );


























