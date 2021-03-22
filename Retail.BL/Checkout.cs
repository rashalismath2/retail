using Retail.COMMON;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public static class Checkout
    {
        public static void DoCheckout(Bill bill, float paid, Cashier cashier) {
            bill.CalculateTotal();
            float balance=bill.CalculateBalance(paid);
            bill.CalculateTotalProductDiscount();

            Console.WriteLine("ABC Retail");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Product \t Qty \t Unit Price \t Total \t Discount");
            Console.WriteLine("--------------------------------");

            PrintBill(bill.products);

            Console.WriteLine("--------------------------------");
            
            Console.WriteLine( $"Paid: Rs.{paid}.00");
            Console.WriteLine($"Total Product Discount: Rs.{bill.TotalProductDiscount}.00");
            Console.WriteLine($"Bill Discount: Rs.{bill.Discount}.00");
            Console.WriteLine($"Total: Rs.{bill.Total}.00");
            Console.WriteLine($"Balance: Rs.{balance}.00");

            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Cashier {cashier.FullName}");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome again!");
            Console.WriteLine("--------------------------------");
        }

        public static void PrintBill(List<Product> products) {
            foreach (var item in products)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
