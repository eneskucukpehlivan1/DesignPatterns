using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Business
{
    public class DatabaseBusiness
    {
        private static DatabaseBusiness _databaseBusiness;
        private DatabaseBusiness() { }
        public static DatabaseBusiness GetInstance()
        {
            if (_databaseBusiness == null)
            {
                _databaseBusiness = new DatabaseBusiness();
            }
            return _databaseBusiness;
        }
    }
}
