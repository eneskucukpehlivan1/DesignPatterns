using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business
{
    public class RS2CryptAdapter : ICrypt
    {
        private RS2Crypt _rs2Crypt;

        public RS2CryptAdapter(RS2Crypt rs2Crypt)
        {

            _rs2Crypt = rs2Crypt;
        }

        public void Encrypt(string text)
        {

            _rs2Crypt.TextToCode(text);
        }

        public void Decrypt(string text)
        {

            _rs2Crypt.CodeToText(text);
        }
    }
}
