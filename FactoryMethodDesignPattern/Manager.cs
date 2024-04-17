using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class Manager : Employee
    {
        public override void Role()
        {
            Console.WriteLine("Rol: Müdür");
        }
    }
}
