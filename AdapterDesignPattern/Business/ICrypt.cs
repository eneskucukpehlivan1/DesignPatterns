using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business
{
    public interface ICrypt
    {
        void Encrypt(string text);

        void Decrypt(string text);
    }
}
