using NUnit.Framework;
using Final_Project.DBAL;
using System;

namespace Final_Project
{
    [TestFixture]
    public class ContactTests
    {
        private Contact _testContact;

        [SetUp]
        public void Setup()
        {
            _testContact = new Contact
            {
                ContactID = 1,
                UserID = 1,
                FullName = "Test User",
                PhoneNumber = "+1234567890",
                Email = "testuser@example.com",
                Address = "123 Test Street",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        [Test]
        public void InsertContacts_ValidData_ReturnsTrue()
        {
            bool result = Contact.InsertContacts(_testContact);
            Assert.IsTrue(result, "InsertContacts failed.");
        }

        [Test]
        public void GetContactByID_ValidID_ReturnsContact()
        {
            Contact.InsertContacts(_testContact);

            var result = Contact.GetContactByID(_testContact.ContactID);
            Assert.IsNotNull(result, "Contact not found.");
            Assert.AreEqual(_testContact.ContactID, result.ContactID, "IDs do not match.");
        }
    }
}
