using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL.Repository
{
    public class BillRepository : IRepository<Bill>
    {
        public bool Delete(int itemId)
        {
            bool IsDeleted = false;

            if (itemId == 1)
            {
                IsDeleted = true;
            }


            return IsDeleted;
        }

        public Bill Retrieve(int itemId)
        {
            Bill bill = null;

            if (itemId == 1) {
                bill= new Bill(1)
                {
                    BillId= itemId,
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
            }
            return bill;
        }

        public List<Bill> Retrieve()
        {
            List<Bill> bills = new List<Bill>()
            {
                new Bill(1)
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
                },
                new Bill(2)
                {
                    BilledDate = DateTime.Now,
                    Customer = new Customer(1),
                    products = new List<Product>() {
                    new UnitProduct()
                        {
                            ProductId = 2,
                            ProductName = "Anchor",
                            SoldPrice = 500,
                            UnitPrice = 500,
                            Qty = 4,
                            ExpirationDate = DateTime.Now.AddDays(2)
                        }
                }
                },
            };
            return bills;
        }

        public bool Save(Bill item)
        {
            bool IsSaved=false;

            if (item.BillId==1) {
                IsSaved = true;
            }

            return IsSaved;
        }

        public Bill Update(Bill item)
        {
            Bill exists = Retrieve(item.BillId);
            Bill bill = item;
            if (exists!=null)
            {
                return item;
            }
            return null;
        }
    }
}
