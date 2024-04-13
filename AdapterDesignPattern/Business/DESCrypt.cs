using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business
{
    public class DESCrypt : ICrypt
    {
        public void Decrypt(string text)
        {
            Console.WriteLine("DES Decrypt");
        }

        public void Encrypt(string text)
        {
            Console.WriteLine("DES Encrypt");
        }
    }
}
