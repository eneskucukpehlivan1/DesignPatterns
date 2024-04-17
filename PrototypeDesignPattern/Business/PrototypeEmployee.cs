using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Business
{
    public abstract class PrototypeEmployee
    {
        public abstract PrototypeEmployee Clone();
    }
}
