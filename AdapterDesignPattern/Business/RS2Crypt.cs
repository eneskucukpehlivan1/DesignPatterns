using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business
{
    public class RS2Crypt
    {
        public void TextToCode(string text)
        {

            Console.WriteLine("RS2 text to code");
        }

        public void CodeToText(string text)
        {

            Console.WriteLine("RS2 code to text");
        }
    }
}
