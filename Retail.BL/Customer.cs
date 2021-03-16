using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL
{
    public class Customer:RoleBase
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; set; }
    }
}
