using Retail.COMMON;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class UnitProduct : Product , IPrintable
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
                return (int)Qty * (float)SoldPrice;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
           
        }

        public string Print()
        {
            return ProductName +" \t" + Qty+" \t"+ SoldPrice+" \t"+CalculateTotal();
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
