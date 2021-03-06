using Retail.BL;
using System;
using System.Collections.Generic;

namespace Retail
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(1) { 
                FirstName="Razzaq",
                LastName="Ismathulla "
            };

            Customer customer = new Customer(1)
            {
                FirstName = "Customer",
                LastName = "Customer "
            };

            Bill bill = new Bill(1)
            {
                BilledDate = DateTime.Now,
                Customer = customer,
                products = new List<Product>() {
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

            Checkout.DoCheckout(bill, 15000, cashier);
        }
    }
}
