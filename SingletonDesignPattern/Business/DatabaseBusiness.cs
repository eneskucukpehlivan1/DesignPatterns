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
        //Thread Safe için lock objesi eklendi
        static object _lock = new object();
        private DatabaseBusiness() { }
        public static DatabaseBusiness GetInstance()
        {
            //Thread Safe
            lock (_lock)
            {
                if (_databaseBusiness == null)
                {
                    _databaseBusiness = new DatabaseBusiness();
                }
            }
            //Non Thread Safe
            //if (_databaseBusiness == null)
            //{
            //    _databaseBusiness = new DatabaseBusiness();
            //}
            return _databaseBusiness;
        }
    }
}
