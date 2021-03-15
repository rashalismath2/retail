using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Retail.BL.TEST
{
    [TestClass]
    public class CustomerTest
    {



        [TestMethod]
        public void Validate_WithEMptyEmail_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                FirstName = "Razzaq",
                LastName = " Ismathulla ",
                Gender="Male",
                HomeAddress = "99A,TEmple rd,Dehiowita",

            };
           

            bool result = customer.ValidateProperties();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Validate_WithEMptyFirstName_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                Email = "sdsd@gmail.com",
                LastName = " Ismathulla ",
                Gender = "Male",
                HomeAddress = "99A,TEmple rd,Dehiowita",

            };


            bool result = customer.ValidateProperties();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Validate_WithEMptyLasttName_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                Email = "sdsd@gmail.com",
                FirstName = "Razzaq",
                Gender = "Male",
                HomeAddress = "99A,TEmple rd,Dehiowita",

            };


            bool result = customer.ValidateProperties();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Validate_WithEMptyGender_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                Email = "sdsd@gmail.com",
                FirstName = "Razzaq",
                LastName = " Ismathulla ",
                HomeAddress = "99A,TEmple rd,Dehiowita",
            };


            bool result = customer.ValidateProperties();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Validate_WithEMptyHomeAddress_ReturnsFalse()
        {
            Customer customer = new Customer()
            {
                Email = "sdsd@gmail.com",
                FirstName = "Razzaq",
                LastName = " Ismathulla ",
                Gender = "Male",
            };


            bool result = customer.ValidateProperties();

            Assert.IsFalse(result);
        }
 


    }
}
