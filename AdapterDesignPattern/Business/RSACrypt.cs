using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business
{
    public class RSACrypt : ICrypt
    {
        public void Decrypt(string text)
        {
            Console.WriteLine("RSA Decrypt");
        }

        public void Encrypt(string text)
        {
            Console.WriteLine("RSA Encrypt");
        }
    }
}
