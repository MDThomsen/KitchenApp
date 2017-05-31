using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp
{
    class SharedCodeTest
    {
        private int magicNumber;
        private string magicString;

        public SharedCodeTest(int magicNumber, string magicString)
        {
            this.magicNumber = magicNumber;
            this.magicString = magicString;
        }
           
        public int getNumber()
        {
            return magicNumber;
        }

        public string getString()
        {
            return magicString;
        }

    }
}
