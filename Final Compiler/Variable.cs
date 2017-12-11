using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompiler
{
    class Variable
    {
        public string name;
        public string type;

        public string STRING_VAL;
        public int INT_VAL;

        public Variable(string _name, string _type, string _SVAL)
        {
            name = _name;
            type = _type;
            STRING_VAL = _SVAL;
        }

        public Variable(string _name, string _type, int _IVAL)
        {
            name = _name;
            type = _type;
            INT_VAL = _IVAL;
        }
    }
}
