using HeartFluttering;
using HeartFluttering.Classes;

namespace UnitTestsHeartFluttering
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CheckSringWithNUmbers()
        {
            bool actual = Examination.CheckLetter("qwerty1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIncorrectNumber()
        {
            bool actual = Examination.CheckNumber("79090578356");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckNumberWithLetter()
        {
            bool actual = Examination.CheckNumber("8909057839s");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckCorrectNumber()
        {
            bool actual = Examination.CheckNumber("89090578356");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckCorrectCity()
        {
            bool actual = Examination.CheckCity("Ижевск");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIncorrectCity()
        {
            bool actual = Examination.CheckCity("Не Ижевск");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Check()
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            Assert.IsNull(authorizationForm.UserAuthorization("Vlad", "1234a"));
        }
    }
}