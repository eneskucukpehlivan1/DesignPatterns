using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class Worker : Employee
    {
        public override void Role()
        {
            Console.WriteLine("Rol: İşçi");
        }
    }
}
