using ChallengeApp;

namespace TestProjectNEW
{

    public class EmployeeTest2
    {
        [Test]
        public void WhenCharLetters_ReturnTheCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Max", "Maxymalny");
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('d');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void WhenTheGradesArePosted_ReturnTheCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Max", "Maxymalny");
            employee.AddGrade(37);
            employee.AddGrade(22);
            employee.AddGrade(21);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual('D', statistics.AverageLetter);
        }
    }
}

