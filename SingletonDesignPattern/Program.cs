using SingletonDesignPattern.Business;

//Singleton ile birlikte DB sınıfı gibi tek seferlik oluşması gereken sınıfları bir kez oluşturup daha sonrasında o insance'ı istediğimiz yerde çağırıp kullanabiliriz.
DatabaseBusiness databaseBusiness = DatabaseBusiness.GetInstance();
