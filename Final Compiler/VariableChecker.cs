using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompiler
{
    class VariableChecker
    {
        public int CheckVariableInt(List<Variable> vars, string name)
        {
            int value = 0;
            foreach(Variable v in vars)
            {
                if (v.name == name)
                {
                    value = v.INT_VAL;
                }
            }
            return value;
        }

        public bool IsVariable(List<Variable> vars, string name)
        {
            bool isvar = false;

            foreach(Variable v in vars)
            {
                if (v.name == name) isvar = true;
            }

            return isvar;
        }
    }
}
