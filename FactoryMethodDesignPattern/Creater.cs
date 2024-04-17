using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public enum Roles
    {
        İşçi,
        Müdür,
        Patron
    }
    public class Creater
    {
        public Employee FactoryMethod(Roles roleType)
        {
            Employee employee = null;
            switch (roleType)
            {
                case Roles.İşçi:
                    employee = new Worker(); break;
                case Roles.Müdür:
                    employee = new Manager(); break;
                case Roles.Patron:
                    employee = new Boss(); break;
            }
            return employee;
        }
    }
}
