using Retail.COMMON;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class UnitProduct : Product 
    {
        public UnitProduct()
        {

        }
        public UnitProduct(int productId)
        {
            this.ProductId = productId;
        }
        public UnitProduct(int productId,string productName,float unitPrice,float soldPrice,int qty,DateTime expirationDate)
        {
            this.ProductName = productName;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.SoldPrice = soldPrice;
            this.Qty = qty;
            this.ExpirationDate = expirationDate;
        }
        public int? Qty { get; set; }
        public override float CalculateTotal()
        {
            try
            {
                Total= (int)Qty * (float)SoldPrice;

                CalculateDiscount();

                Total = Total - Discount;
                return (float)Total;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
           
        }

        public override string Print()
        {
            return ProductName +" \t\t" + Qty+" \t"+ "Rs."+SoldPrice+".00"+" \t Rs."+CalculateTotal()+".00 \t"+Discount;
        }

        public override bool Validate()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) IsValid = false;
            if (SoldPrice == null || UnitPrice == null ||Qty==null ) IsValid = false;
            if (IsExpired()) IsValid = false;

            return IsValid;
        }
    }
}
