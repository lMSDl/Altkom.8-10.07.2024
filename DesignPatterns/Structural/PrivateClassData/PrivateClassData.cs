using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.PrivateClassData
{
    internal class PrivateClassData
    {
        private string _someString;
        private int _someInt;

        public PrivateClassData(string someString, int someInt)
        {
            _someString = someString;
            _someInt = someInt;
        }

        public int GetSomeInt()
        {
            return _someInt;
        }

        public string GetSomeString()
        {
            return _someString;
        }
    }
}
