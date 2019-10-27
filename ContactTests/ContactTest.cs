using System;
using Charp_OOP.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactTests
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Contact contact = new Contact
            {
                FirstName = "Roland",
                LastName = "Barro"
            };

            string expected = "Barro, Roland";

            // -- Act
            string actual = contact.GetFullName();

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void EmptyFirstNameTestValid()
        {
            // -- Arrange
            Contact contact = new Contact
            {
                FirstName = "Roland"
            };

            string expected = "Roland";

            // -- Act
            string actual = contact.GetFullName();

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void EmptyLastNameTestValid()
        {
            // -- Arrange
            Contact contact = new Contact
            {
                LastName = "Barro"
            };

            string expected = "Barro";

            // -- Act
            string actual = contact.GetFullName();

            // -- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
