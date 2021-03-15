using Retail.COMMON;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public enum WeightUnits { 
        Kg,
        g
    }
    public class WeighProduct : Product , IPrintable
    {
        public WeighProduct()
        {

        }
        public WeighProduct(int productId)
        {
            this.ProductId = productId;
        }
        public WeighProduct(int productId, string productName, float unitPrice, float soldPrice,WeightUnits weightUnit ,float weight, DateTime expirationDate)
        {
            this.ProductName = productName;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.SoldPrice = soldPrice;
            this.Weight = weight;
            this.WeightUnit = weightUnit;
            this.ExpirationDate = expirationDate;
        }
        public WeightUnits WeightUnit { get; set; }
        public float? Weight { get; set; }
        public override float CalculateTotal()
        {
            try
            {
                float total = 0;
                switch (WeightUnit)
                {
                    case WeightUnits.Kg:
                        total= (float)SoldPrice * (float)Weight;
                        break;
                    case WeightUnits.g:
                        total= ((float)SoldPrice) / 1000 * (float)Weight;
                        break;
                    default:
                        total = 0;
                        break;
                }
                return total;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            
        }

        public string Print()
        {
            return ProductName + " \t" + Weight +" "+WeightUnit +" \t" + SoldPrice + " \t" + CalculateTotal();
        }

        public override bool Validate()
        {
            bool IsValid = true;

            if(string.IsNullOrWhiteSpace(ProductName)) IsValid=false;
            if (SoldPrice==null || UnitPrice== null || Weight == null ) IsValid = false;
            if (IsExpired()) IsValid = false;

            return IsValid;
        }
    }
}
