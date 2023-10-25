using ChallengeApp;

namespace TestProjectNEW
{
    public class EmployeeTest2
    {
        [Test]
        public void AverageValueSupervisorTest()
        {
            // arrange
            var supervisor = new Supervisor("Max", "Maxymalny");
            supervisor.AddGrade("5");
            supervisor.AddGrade("4+");
            supervisor.AddGrade("-3");

            // act
            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(60, statistics.Average);
        }
        [Test]
        public void MinValueSupervisorTest()
        {
            // arrange
            var supervisor = new Supervisor("Max", "Maxymalny");
            supervisor.AddGrade("6-");
            supervisor.AddGrade("4-");
            supervisor.AddGrade("+1");
            // act
            var statistics = supervisor.GetStatistics();
            // assert
            Assert.AreEqual(5, statistics.Min);
        }
        [Test]
        public void MaxValueSupervisorTest()
        {
            // arrange
            var supervisor = new Supervisor("Max", "Maxymalny");
            supervisor.AddGrade("5+");
            supervisor.AddGrade("3");
            supervisor.AddGrade("+2");
            // act
            var statistics = supervisor.GetStatistics();
            // assert
            Assert.AreEqual(85, statistics.Max);
        }
        [Test]
        public void AverageLetterValueSupervisorTest()
        {
            // arrange
            var supervisor = new Supervisor("Max", "Maxymalny");
            supervisor.AddGrade("2-");
            supervisor.AddGrade("-4");
            supervisor.AddGrade("6");
            // act
            var statistics = supervisor.GetStatistics();
            // assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}

