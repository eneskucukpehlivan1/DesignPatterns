using FacadeDesingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesingPattern.Business
{
    public class Order
    {
        private Customer customer;
        private ShippingCompany shippingCompany;
        private ProductTransactions productTransactions = new ProductTransactions();
        private OrderTransactions orderTransactions = new OrderTransactions();
        private OrderDetails orderDetails = new OrderDetails();


        public void AddOrder(string customerFirstName, string customerLastName, string selectedShippingCompany, List<Basket> products)
        {
            customer = new Customer { FirstName = customerFirstName, LastName = customerLastName };
            shippingCompany = new ShippingCompany { Name = selectedShippingCompany };
            int orderId = orderTransactions.AddOrder(DateTime.Now, customer, shippingCompany);
            orderDetails.AddOrderDetails(orderId, products);
            products.ForEach(u => productTransactions.UpdateStock(u.Id, u.Quantity));
            Console.WriteLine();
            Console.WriteLine("İşlem tamamlandı");


        }
    }
}
