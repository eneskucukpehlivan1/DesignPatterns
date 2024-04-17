using PrototypeDesignPattern.Models;

//Prototype Desing Pattern ile birlikte constructor'ında çok fazla eleman isteyen bir sınıfıno anki kopyası alınıp o kopya üzerinden işlem yapılabilir.
//Bu şekilde new'leme maliyetinden kurtulmuş olunur. Aynı zamanda her yeni nesne için constructor'daki tüm özellikleri tek tek girmeye gerek kalmaz.

Employee employee = new Employee(Guid.NewGuid(), "Enes", "Yazılım");
Employee employee2 = (Employee)employee.Clone();
employee2.Name = "Ahmet";
employee2.Id = Guid.NewGuid();

Console.WriteLine($"1. çalışan isim: {employee.Name} | 2. çalışan isim: {employee2.Name}");
Console.ReadLine();