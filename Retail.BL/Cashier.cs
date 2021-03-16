using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class Cashier : RoleBase
    {
        public Cashier()
        {

        }
        public Cashier(int cahierId)
        {
            CashierId = CashierId;
        }

        public int CashierId { get; set; }
    }
}
