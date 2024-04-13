using AdapterDesignPattern.Business;
using System;

//Mevcut yapıda RSACrypt ve DESCrypt sınıfları ICrypt interface'inden implemente edildiği için bir sorun yok.
//Ancak ilerleyen zamanlarda şifreleme olarak RS2 kullanılmak istendiğinde mevcut yapıyı komple bozmamak için RS2'nin ICrypt'ten implemente edilen bir adatör sınıfı yazılır.
//Bu adaptör sınıf ihtiyac olan sınıfı mevcut yapıya uyumlu hale getirmek için kullanılır.
//Adapter Design Pattern özetle mevcut yapıyı ya da yeni eklenen sınıfı değiştirmeden araya ikisini birleştirecek bir ara adaptör eklenmesini önerir.

ICrypt crypt = new RSACrypt();
crypt.Encrypt("Enes");
crypt.Decrypt("Elif");

Console.WriteLine("-------------");

crypt = new DESCrypt();
crypt.Encrypt("Enes");
crypt.Encrypt("Meva");
Console.WriteLine("-------------");

RS2Crypt rs2Crypt = new RS2Crypt();

crypt = new RS2CryptAdapter(rs2Crypt);
crypt.Encrypt("Ahmet");
crypt.Decrypt("Mehmet");

Console.ReadLine();