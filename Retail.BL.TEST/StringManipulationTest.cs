using Microsoft.VisualStudio.TestTools.UnitTesting;
using Retail.COMMON;
using System;

namespace Retail.BL.TEST
{
    [TestClass]
    public class StringManipulationTest
    {
        [TestMethod]
        public void Validate_WithPropperEMailAddress_ReturnsTrue()
        {
            Customer customer = new Customer()
            {
                Email = "abc@sgmail.com",
                FirstName = "Razzaq",
                LastName = " Ismathulla ",
                Gender = "Male",
                HomeAddress = "99A,TEmple rd,Dehiowita",
            };

            bool result = StringManipulation.ValidateEmail(customer.Email);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateEmail_WithWrongEMailAddress_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                Email = "sgmail.com",
                FirstName = "Razzaq",
                LastName = " Ismathulla ",
                Gender = "Male",
                HomeAddress = "99A,TEmple rd,Dehiowita",
            };

            bool result = StringManipulation.ValidateEmail(customer.Email);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void FullName_FirstNameAndLastName_WithSimpleLetters_Returns_FormatedFullName()
        {
            Customer customer = new Customer()
            {
                FirstName = " razzaq ",
                LastName = " ismathulla "
            };
            string expected = "Razzaq Ismathulla";

            string result = customer.FullName;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void FullName_FirstNameAndLastName_WithEmpty_ReturnsEmpty()
        {
            Customer customer = new Customer()
            {
                FirstName = "  ",
                LastName = "  "
            };
            string expected = "";

            string result = customer.FullName;

            Assert.AreEqual(expected, result);


        }
    }
}
