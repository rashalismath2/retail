using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Retail.BL.TEST
{
    [TestClass]
    public class BillTest
    {
        [TestMethod]
        public void CalculateTotal_WithProducts()
        {
            //arrange
            Bill bill = new Bill(1)
            {
                BilledDate = DateTime.Now,
                Customer=new Customer(1),
                products=new List<Product>() {
                    new UnitProduct()
                        {
                            ProductId = 1,
                            ProductName = "Anchor",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        },
                    new WeighProduct()
                        {
                            ProductId = 1,
                            WeightUnit = WeightUnits.Kg,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Weight = 4,
                            ExpirationDate = DateTime.Now
                        },
                    new UnitProduct()
                        {
                            ProductId = 1,
                            ProductName = "Noodles",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        },
                    new WeighProduct()
                        {
                            ProductId = 1,
                            WeightUnit = WeightUnits.Kg,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Weight = 4,
                            ExpirationDate = DateTime.Now
                        },
                    new WeighProduct()
                        {
                            ProductId = 1,
                            WeightUnit = WeightUnits.Kg,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Weight = 4,
                            ExpirationDate = DateTime.Now
                        },
                    new UnitProduct()
                        {
                            ProductId = 1,
                            ProductName = "Biscuits",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        },
                    new WeighProduct()
                        {
                            ProductId = 1,
                            WeightUnit = WeightUnits.Kg,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Weight = 4,
                            ExpirationDate = DateTime.Now
                        }
                }

            };

            float expected = (1960 * 7) - ((1960 * 7)*5) / 100;
            //act
            float result = bill.CalculateTotal();

            //assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void CalculateBalance_WithProducts()
        {
            Bill bill = new Bill(1) {
                BilledDate = DateTime.Now,
                Customer = new Customer(1),
                products = new List<Product>() {
                    new UnitProduct()
                        {
                            ProductId = 1,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        }
                }
            };

            bill.CalculateTotal();

            float paid = 2000;
            float expected = 40;
            float result = bill.CalculateBalance(paid);


            Assert.AreEqual(expected,result);
            
        }
        [TestMethod]
        public void TotalProductDiscount_WithProducts()
        {
            Bill bill = new Bill(1)
            {
                BilledDate = DateTime.Now,
                Customer = new Customer(1),
                products = new List<Product>() {
                    new UnitProduct()
                        {
                            ProductId = 1,
                            ProductName = "Rice",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        }
                }
            };

            bill.CalculateTotal();
            
            float expected = 40;
            float result = bill.CalculateTotalProductDiscount(); ;


            Assert.AreEqual(expected, result);

        }

    }
}
