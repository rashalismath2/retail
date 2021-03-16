using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Retail.BL.TEST
{
    [TestClass]
    public class UnitProductTest
    {
        [TestMethod]
        public void CalculateTotal_WithNullSoldPrice_Returns_0()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Book",
                UnitPrice = 90,

                Qty = 5,
                ExpirationDate = DateTime.Now
            };

            float expectd = 0;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd, result);
        }
        [TestMethod]
        public void CalculateTotal_Returns_qty_into_soldPrice()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Book",
                UnitPrice = 90,
                SoldPrice=90,
                Qty=5,
                ExpirationDate = DateTime.Now
            };

            float expectd = 450;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd, result);
        }
        [TestMethod]
        public void CalculateTotal_WithNullQty_Returns_0()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Book",
                UnitPrice = 90,
                SoldPrice = 90,
                ExpirationDate = DateTime.Now
            };


            float expectd = 0;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd, result);
        }
        [TestMethod]
        public void Validate_WithEmptyProductName_Returns_false()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                UnitPrice = 90,
                SoldPrice = 90,
                Qty = 5,
                ExpirationDate = DateTime.Now
            };

            //act
            bool result = product.Validate();
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Validate_WithExpiredDate_Returns_false()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                SoldPrice = 90,
                UnitPrice = 90,
                Qty=5,
                ExpirationDate = DateTime.Now.AddDays(2)
            };

            //act
            bool result = product.Validate();
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Validate_WithNonExpiredDate_Returns_true()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                SoldPrice = 90,
                UnitPrice = 90,
                Qty = 5,
                ExpirationDate = DateTime.Now
            };

            //act
            bool result = product.Validate();
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CalculateTotal_With2000Total_Returns_1960()
        {
            //arrange
            UnitProduct product = new UnitProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                SoldPrice = 500,
                UnitPrice = 500,
                Qty = 4,
                ExpirationDate = DateTime.Now.AddDays(2)
            };
            float expected = 1960;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
