using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenThisSameValueInt_ThenIntsAreEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenCreatingNewUserWithTheSameLogin_ThenNotTheSameLogin()
        {
            var user1 = GetUser("Kuba");
            var user2 = GetUser("Kuba");





            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void WhenNoCapitalLetter_ThenNotTheSameUser()
        {
            string user1 = ("Asia");
            string user2 = ("asia");





            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
