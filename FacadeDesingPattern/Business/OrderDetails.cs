using FacadeDesingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesingPattern.Business
{
    internal class OrderDetails
    {
        public void AddOrderDetails(int orderId, List<Basket> products)
        {
            Console.WriteLine($"{orderId} numaralı siparişte alınan ürünler:");
            Console.WriteLine("...............................");
            products.ForEach(u => Console.WriteLine($"{u.ProductName} ürününden {u.Quantity} adet alındı. Ara toplam:{u.Quantity * u.Price}"));
            Console.WriteLine("...............................");
            var total = products.Sum(x => x.Price * x.Quantity);
            Console.WriteLine($"Toplam:{total} TL");

        }
    }
}
