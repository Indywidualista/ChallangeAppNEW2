using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenUserPositivePoints()
        {

            var harvestingPositiveNumber = new Employee("Jan", "Kowalski", "25");
            harvestingPositiveNumber.AddScore(8);
            harvestingPositiveNumber.AddScore(2);
            harvestingPositiveNumber.AddScore(11);

            var harvestingPositiveNumberResult = harvestingPositiveNumber.Result;

            Assert.AreEqual(21, harvestingPositiveNumberResult);
           
        }

        [Test]
        public void WhenUserNegativePoints()
        {

            var harvestingNegativeNumber = new Employee("Jan", "Kowalski", "25");
            harvestingNegativeNumber.AddScore(-8);
            harvestingNegativeNumber.SubstractScore(2);
            harvestingNegativeNumber.AddScore(1);

            var harvestingNegativeNumberResult = harvestingNegativeNumber.Result;

            Assert.AreEqual(-9, harvestingNegativeNumberResult);

        }

        [Test]
        public void WhenUserSubstractPoints()
        {

            var user = new Employee("Jan", "Kowalski", "25");
            user.AddScore(20);
            user.SubstractScore(5);
            user.SubstractScore(4);

            var result = user.Result;

            Assert.AreEqual(11, result);

        }



    }
}