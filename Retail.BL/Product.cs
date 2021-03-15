using System;

namespace Retail.BL
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float? SoldPrice { get; set; }
        public float? UnitPrice { get; set; }
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
    }
}
