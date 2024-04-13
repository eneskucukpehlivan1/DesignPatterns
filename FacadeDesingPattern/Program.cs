using FacadeDesingPattern.Business;
using FacadeDesingPattern.Models;


//Facade design pattern'ine göre arka tarafta yapılan tüm işlemlerin tek bir iş sınıfında toplanması ve ön tarafta isteğin sadece o iş sınıfına yapılmasını gerekir.
//Mevcut örnekte siparişi kaydetme kargo ürün işlemleri sipariş detayları gibi tüm işler order iş sınıfında toplanmıştır.
//Sipariş isteğinin order iş sınıfının AddOrder methodu ile yapılması yeterli olmuştur. 

Order order = new Order();
List<Basket> products = new List<Basket>
            {
                new Basket{ Id=1, ProductName="X", Price=5, Quantity=2},
                new Basket{ Id=2, ProductName="Y", Price=8, Quantity=3},
                new Basket{ Id=3, ProductName="Z", Price=10, Quantity=1},
                new Basket{ Id=4, ProductName="Q", Price=20, Quantity=1}
            };
order.AddOrder("Enes","Küçükpehlivan", "Aras Kargo", products);
Console.ReadLine();