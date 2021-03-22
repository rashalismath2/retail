using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class Bill
    {
        public Bill()
        {

        }
        public Bill(int billId)
        {
            BillId = billId;
        }
        public int BillId { get; set; }
        public DateTime BilledDate { get; set; }
        public Customer Customer { get; set; }
        public List<Product> products { get; set; }
        public float? Total { get; protected set; }
        public float? Discount { get; protected set; }
        public float? TotalProductDiscount { get; protected set; }
        public float CalculateTotalProductDiscount() {
            TotalProductDiscount = 0;
            foreach (Product product in products)
            {
                TotalProductDiscount += product.Discount;
            }
            return (float)TotalProductDiscount;
        }

        public float CalculateTotal()
        {
            Total = 0;
            foreach (Product product in products)
            {
                Total += product.CalculateTotal();

            }
            if (Total != null)
            {
                CalculateDiscount();
                Total = Total - Discount;
                return (float)Total;
            }
            else return 0;

        }

        public float CalculateDiscount() {
            float discount = 0;

            if (Total >= 10000) {
                discount = ((float)Total * 5) / 100;
            }
            Discount = discount;
            return discount;
        }

        public float CalculateBalance(float paid) {
            return paid-(float)Total;
        }
    }
}
