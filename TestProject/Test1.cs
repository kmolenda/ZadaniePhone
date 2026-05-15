using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstruktor_parametr_owner_OK()
        {
            // AAA

            // Arrange
            string owner = "Molenda";

            // Act
            var telefon = new Phone(owner, "123456789");

            // Assert
            Assert.AreEqual(owner, telefon.Owner);
        }


        [TestMethod]
        public void Konstruktor_parametr_owner_NULL()
        {
            // AAA
            string owner = null;
            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => new Phone(owner, "123456789")
            );
        }

        [TestMethod]
        public void Konstruktor_parametr_owner_EMPTY()
        {
            string owner = "";
            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => new Phone(owner, "123456789")
            );
        }


        [TestMethod]
        public void Konstruktor_parametr_phoneNumber_OK()
        {
            // Arrange
            string phoneNumber = "123456789";
            // Act
            var telefon = new Phone("Molenda", phoneNumber);
            // Assert
            Assert.AreEqual(phoneNumber, telefon.PhoneNumber);
        }


        // test dla Count
        [TestMethod]
        public void Count_OK()
        {
            // Arrange
            var telefon = new Phone("Molenda", "123456789");
            // Act
            telefon.AddContact("Nowak", "987654321");
            telefon.AddContact("Kowalski", "111222333");
            // Assert
            Assert.AreEqual(2, telefon.Count);
        }
    }
}
