using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime BilledDate { get; set; }
        public Customer Customer { get; set; }
        public List<Product> products { get; set; }
        public float Total { get; set; }

        public void CalculateTotal() {
            foreach (Product product in products)
            {
                Total += product.CalculateTotal();
            }
        }

        public float CalculateDiscount() {
            float discount = 0;

            if (Total >= 10000) {
                discount = (Total * 5) / 100;
            }
            else if (Total>=2000 && Total<10000) {
                discount = (Total * 2) / 100;
            }

            return discount;
        }

        public float CalculateBalance() { }
    }
}
