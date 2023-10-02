using ChallengeApp;

namespace TestProjectNEW
{

    public class EmployeeTest2
    {
        [Test]
        public void testGetStatisticsAverage()
        {
            var employee = new Employee("Stefan", "Kasztanek");
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(0);

            var result = employee.GetStatistics();

            Assert.AreEqual(5, result.Average);




        }

        [Test]
        public void testGetStatisticsMax()
        {
            var employee = new Employee("Stefan", "Kasztanek");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade(8);

            var result = employee.GetStatistics();

            Assert.AreEqual(8, result.Max);





        }

        [Test]
        public void testGetStatisticsMin()
        {
            var employee = new Employee("Stefan", "Kasztanek");
            employee.AddGrade(-1);
            employee.AddGrade(1);
            employee.AddGrade(0);

            var result = employee.GetStatistics();

            Assert.AreEqual(-1, result.Min);
        }



    }
}

