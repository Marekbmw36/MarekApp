using System.Reflection.Metadata;

namespace ConsoleApp4Tests_
{
    public class Tests
    {

        [Test]
        public void WhenFiveNumberAreAdde_ShouldReturnSum()
        {
            var employee1 = new Employee("Piotr", "Nowak", 27);
            employee1.AddScore(5);
            employee1.AddScore(-4);
            employee1.AddScore(1);
            employee1.AddScore(6);
            employee1.AddScore(5);

            var result = employee1.Result;

            Assert.AreEqual(13, result);

        }
        [Test]
        public void WhenEmployeeCollectFiveScores_ShouldCoorrectReturn()
        {
            var employee2 = new Employee("Micha³", "Kowalski", 33);
            employee2.AddScore(5);
            employee2.AddScore(-4);
            employee2.AddScore(1);
            employee2.AddScore(5);
            employee2.AddScore(-6);

            var result = employee2.Result;

            Assert.AreEqual(1, result);

        }

        [Test]
        public void WhenFiveNumberAreAddedScoreCorrect_ShouldReturnSum()
        {
            var employee3 = new Employee("£ukasz", "Zdanewicz", 24);
            employee3.AddScore(5);
            employee3.AddScore(-2);
            employee3.AddScore(1);
            employee3.AddScore(9);
            employee3.AddScore(5);

            var result = employee3.Result;

            Assert.AreEqual(18, result);

        }
    }
}