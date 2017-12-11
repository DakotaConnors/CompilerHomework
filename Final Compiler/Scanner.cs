using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompiler
{
    class Scanner
    {
        bool info = false;
        VariableChecker checker = new VariableChecker();

        List<string> KeyWords = new List<string>()
        {
            "LET",
            "PRINT",
            "INPUT",
            "IF",
            "TRUE",
            "FALSE",
            "WHILE"
        };


        public string isKeyWord(string token)
        {
            bool iskeyword = false;
            if (KeyWords.Contains(token)) iskeyword = true;
            if (info && iskeyword) Console.WriteLine(token + " is KeyWord");


            if (iskeyword) return "KEYWORD" + "_" + token;
            else return "INVALID_TOKEN";
        }

        public string isNum(string token)
        {
            bool isnum = true;

            foreach(char c in token)
            {
                if (Convert.ToInt32(c) < 48 || Convert.ToInt32(c) > 58) isnum = false;
            }

            if (info && isnum) Console.WriteLine(token + " is NUM");

            if (isnum) return "NUM";
            else return "INVALID_TOKEN";
        }

        public string isLet(string token)
        {
            bool islet = true;
            foreach(char c in token)
            {
                if (Convert.ToInt32(c) < 65 || (Convert.ToInt32(c) > 90 && Convert.ToInt32(c) < 97) || Convert.ToInt32(c) > 122) islet = false;
            }
            if (info && islet) Console.WriteLine(token + " is LETTER");
            if (islet) return "LETTER";
            else return "INVALID_TOKEN";
        }

        public bool isID(string token)
        {
            bool isid = true;

            if (token[0] != '_' && (isNum(Convert.ToString(token[0])) == "INVALID_TOKEN") && (isLet(Convert.ToString(token[0])) == "INVALID_TOKEN"))isid = false;
            
            for(int i = 1; i < token.Length; i++)
            {
                if ((isNum(Convert.ToString(token[0])) == "INVALID_TOKEN") && (isLet(Convert.ToString(token[0])) == "INVALID_TOKEN")) isid = false;
            }

            if (info && isid) Console.WriteLine(token + " is ID");
            return isid;
        }

        public string isOperator(string token)
        {
            bool isoperator = true;

            List<string> ops = new List<string>()
            {
                "+", "-",  "*", "/", "=", ":", ">", "<"
            };

            if (!ops.Contains(token)) isoperator = false;

            if (isoperator) return ("OPERATOR" + "_" + token);
            else return "INVALID_TOKEN";
        }

        public string isString(string token)
        {
            bool isstring = false;

            if (token.Length > 0)
                if (token[0] == '"' && token.Last() == '"') isstring = true;

            if (isstring) return "STRING";
            else return "INVALID_OPERATOR";
        }

        public string isInputAssign(string token)
        {
            bool isinput = true;

            if (!token.StartsWith("$")) isinput = false;
            else if (!isID(token.Remove(0, 1))) isinput = false;

            if (isinput) return "INPUT_ASSIGN";
            else return "INVALID_TOKEN";
        }

        public string isToken(string token)
        {
            string istoken = "INVALID_TOKEN";

            if (isKeyWord(token).StartsWith("KEYWORD")) istoken = isKeyWord(token);
            else if (isOperator(token).StartsWith("OPERATOR")) istoken = isOperator(token);
            else if (isString(token) == "STRING") istoken = "STRING";
            else if (isNum(token) == "NUM") istoken = "NUM";
            else if (isID(token)) istoken = "ID";
            else if (isInputAssign(token) == "INPUT_ASSIGN") istoken = "INPUT";

            return istoken;
        }
    }
}
