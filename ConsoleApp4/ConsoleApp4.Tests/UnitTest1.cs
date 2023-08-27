namespace ConsoleApp4.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectStatictis()
        {
            var employee = new Employee("Pawe³", "Kowalski", 27);
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(5.5f, statistic.Average);
            Assert.AreEqual(3,statistic.Min);
            Assert.AreEqual(8, statistic.Max);          
            
        }                                                                                                                                            
        
    }  
}