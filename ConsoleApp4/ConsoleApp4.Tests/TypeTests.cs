
namespace ConsoleApp4.Tests
{
    public class TypeTests
    {
        [Test]
        public void ChekingThatThreeEmployeesAreNotEqual()
        {
            var employee1 = GetEmployee("Piotr", "Nowak", 27);
            var employee2 = GetEmployee("Michał", "Nowak", 27);
            var employee3 = GetEmployee("Łukasz", "Nowak", 27);

            Assert.AreNotEqual(employee1.Name, employee2.Name, employee3.Name);

        }
        [Test]
        public void ChekingIfThreeStringsAreEqaal()
        {
            string name1 = "Piotr";
            string name2 = "Piotr";
            string name3 = "Piotr";

            Assert.AreEqual(name1, name2, name3);

        }
        [Test]
        public void ChekingThreeNumbersAreEqual()
        {
            int number1 = 17;
            int number2 = 17;
            int number3 = 17;

            Assert.AreEqual(number1 , number2 , number3);
        }

        private Employee GetEmployee(string name, string surname , int age )
        {
            return new Employee (name ,surname,age);
        }
        
    }
}
    

