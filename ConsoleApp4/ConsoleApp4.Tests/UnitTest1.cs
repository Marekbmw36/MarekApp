namespace ConsoleApp4.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhhenGetStatisticsCallect_ShouldReturnCorrectMax()
        {
            var employee = new Employee("Pawe³", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(8, statistic.Max);          
            
        }

        [Test]
        public void WhenGetStatisticsCallect_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Pawe³", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(3, statistic.Min);
           
        }

        [Test]
        public void WhenGetStatisticsCallect_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Pawe³", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(Math.Round(5.5,2),Math.Round( statistic.Average,2));         

        }
    }  
}