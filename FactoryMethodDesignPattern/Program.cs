using FactoryMethodDesignPattern;

//Factory Method Design Pattern ile tek bir creator method üzerinden istenilen sınıfın nesnesini üretip ilişkisiz nesne üretimlerinin önüne geçilebilir.

Creater creater = new Creater();
Employee isci = creater.FactoryMethod(Roles.İşçi);
Employee mudur = creater.FactoryMethod(Roles.Müdür);
Employee patron = creater.FactoryMethod(Roles.Patron);

isci.Role();
mudur.Role();
patron.Role();

Console.ReadLine();