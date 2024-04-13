using FacadeDesingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesingPattern.Business
{
    public class OrderTransactions
    {
        public int AddOrder(DateTime orderDate, Customer customer, ShippingCompany shippingCompany)
        {
            Console.WriteLine($"{orderDate} tarihinde {customer.FirstName} {customer.LastName} isimli müşteri siparişi eklendi. Seçilen kargo şirketi:{shippingCompany.Name} ");
            return 1;
        }
    }
}
