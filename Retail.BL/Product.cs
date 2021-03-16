using Retail.COMMON;
using System;

namespace Retail.BL
{
    public abstract class Product : IPrintable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float? SoldPrice { get; set; }
        public float? UnitPrice { get; set; }
        public float? Total { get; set; }
        public float? Discount { get; set; }
        private int ExpireInDays { 
            get { return 1; } 
        }
        public DateTime? ExpirationDate { get; set; }
        public abstract float CalculateTotal();
        public abstract bool Validate();
        public bool IsExpired() {
            if (ExpirationDate == null) return false;
            
            bool check = false;
            if (ExpirationDate >= DateTime.Now.AddDays(ExpireInDays)) check = true;
            return check;
            
        }
        public float CalculateDiscount() {
            if (Total != null && Total >= 2000)
            {
                Discount = (Total * 2) / 100;
                return (float)Discount;
            }
            else {
                Discount = 0;
                return 0;
            }
        }

        public abstract string Print();
    }
}
