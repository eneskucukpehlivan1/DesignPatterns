using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesingPattern.Business
{
    public class ProductTransactions
    {
        public void UpdateStock(int productId, int quantity)
        {
            Console.WriteLine($"{productId} id'li ürünün stoğundan, {quantity} adet düşüldü.");
        }
    }
}
