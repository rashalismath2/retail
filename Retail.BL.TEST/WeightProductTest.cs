using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Retail.BL.TEST
{
    [TestClass]
    public class WeightProductTest
    {
        [TestMethod]
        public void CalculateTotal_WithNullSoldPrice_Returns_0()
        {
            //arrange
            WeighProduct product = new WeighProduct() { 
                ProductId=1,
                ProductName="Rice",
                WeightUnit=WeightUnits.Kg,
                UnitPrice=90,
                Weight=5,
                ExpirationDate=DateTime.Now
            };

            float expectd = 0;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd,result);
        }
        [TestMethod]
        public void CalculateTotal_WeightInKg_Returns_weight_into_soldPrice()
        {
            //arrange
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                WeightUnit = WeightUnits.Kg,
                SoldPrice = 90,
                Weight = 5,
                ExpirationDate = DateTime.Now
            };

            float expectd = 450;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd, result);
        }
        [TestMethod]
        public void CalculateTotal_WeightIng_Returns_weight_into_soldPrice()
        {
            //arrange
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                WeightUnit = WeightUnits.g,
                SoldPrice = 100,
                Weight = 500,
                ExpirationDate = DateTime.Now
            };

            float expectd = 50;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expectd, result);
        }
        [TestMethod]
        public void CalculateTotal_WithNullWeight_Returns_0()
        {
            //arrange
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                ProductName = "Rice",
                WeightUnit = WeightUnits.Kg,
                SoldPrice = 90,
                UnitPrice = 90,
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
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                WeightUnit = WeightUnits.Kg,
                SoldPrice = 90,
                UnitPrice = 90,
                Weight=5,
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
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                WeightUnit = WeightUnits.Kg,
                ProductName="Rice",
                SoldPrice = 90,
                UnitPrice = 90,
                Weight = 5,
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
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                WeightUnit = WeightUnits.Kg,
                ProductName = "Rice",
                SoldPrice = 90,
                UnitPrice = 90,
                Weight = 5,
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
            WeighProduct product = new WeighProduct()
            {
                ProductId = 1,
                WeightUnit = WeightUnits.Kg,
                ProductName = "Rice",
                SoldPrice = 500,
                UnitPrice = 500,
                Weight = 4,
                ExpirationDate = DateTime.Now
            };
            float expected = 1960;
            //act
            float result = product.CalculateTotal();
            //assert
            Assert.AreEqual(expected,result);
        }
    }
}
