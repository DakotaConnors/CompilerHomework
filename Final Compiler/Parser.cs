using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompiler
{
    class Parser
    {
        public Scanner scanner = new Scanner();

        public bool isExpression(string[] tokens)
        {
            bool expr = true;

            if (tokens.Length % 2 == 0) expr = false;
            else if (tokens.Length == 1)
            {
                expr = false;
                if (scanner.isID(tokens[0]))
                {
                    expr = true;
                }

                else if (scanner.isNum(tokens[0]) == "NUM")
                {
                    expr = true;
                }

                else if (scanner.isLet(tokens[0]) == "LETTER")
                {
                    expr = true;
                }
            }
            else if (tokens.Length > 1)
            {
                if (scanner.isID(tokens[0]) || scanner.isNum(tokens[0]) == "NUM")
                    if (scanner.isOperator(tokens[1]).StartsWith("OPERATOR")) ;
                    else expr = false;
                else expr = false;

                List<string> tempTokens = tokens.ToList<string>();
                tempTokens.RemoveAt(0);
                tempTokens.RemoveAt(0);
                expr = isExpression(tempTokens.ToArray());
            }

            return expr;
        }

        public string ExpressionString()
        {
            string expr = "";

            return expr;
        }

        public bool LetCommand(List<string> tokens)
        {
            bool isLET = true;

            if (!tokens[0].EndsWith("LET"))
            {
                isLET = false;
                //Console.WriteLine("first token wrong");
            }

            else if (tokens[1] != "ID")
            {
                isLET = false;
                //Console.WriteLine("second token wrong");
            }

            else if (!tokens[2].EndsWith("="))
            {
                isLET = false;
                //Console.WriteLine("third token wrong");
            }
            else
            {
                List<string> tempTokens = tokens;
                tempTokens.RemoveAt(0);
                tempTokens.RemoveAt(0);
                tempTokens.RemoveAt(0);
                string[] tokenArray = tokens.ToArray();

                if (!isExpression(tokenArray))
                {
                    isLET = false;
                    //Console.WriteLine("fourth token wrong");
                }
            }

            return isLET;
        }

        public bool PrintCommand(List<string> tokens)
        {
            bool isPRINT = true;

            if (tokens.Count() < 2) isPRINT = false;
            else if (!tokens[0].EndsWith("PRINT")) isPRINT = false;
            return isPRINT;
        }

        public bool InputCommand(List<string> tokens)
        {
            bool isINPUT = true;

            if (tokens.Count() < 2) isINPUT = false;
            else if (!tokens[0].EndsWith("INPUT")) isINPUT = false;
            //else if (!tokens[1].StartsWith("$")) isINPUT = false;

            return isINPUT;
        }

        public bool IfCommand(List<string> tokens)
        {
            bool isIF = true;

            if (tokens.Count < 6) isIF = false;

            else
            {
                if (!tokens[0].EndsWith("IF")) { isIF = false; Console.WriteLine("1"); }
                //else if (!tokens[1].EndsWith("IF")) { isIF = false; Console.WriteLine("2"); }
                else if (!tokens[2].StartsWith("OPERATOR")) { isIF = false; Console.WriteLine("3"); }
                else if (tokens[3] != "ID" && tokens[3] != "NUM" && tokens[3] != "STRING") { isIF = false; Console.WriteLine("4"); }
                else if (!tokens[4].EndsWith(":")) isIF = false;

                else
                {
                    for (int i = 0; i < 5; i++) tokens.RemoveAt(0);
                    string answer = CheckSyntax(tokens);
                    if (answer == "INVALID_SYNTAX") { isIF = false; Console.WriteLine("6"); }
                }
            }

            return isIF;
        }

        public bool WhileCommand(List<string>tokens)
        {
            bool isWHILE = true;
            if (!tokens[0].EndsWith("WHILE")) { isWHILE = false; Console.WriteLine("1"); }
            //else
            //{
            //    tokens.RemoveAt(0);
            //    string answer = CheckSyntax(tokens);
            //    if (answer == "INVALID_SYNTAX") isWHILE = false;
            //}

            return isWHILE;
        }

        public string CheckSyntax(List<string> ScannedTokens)
        {
            string isCorrect = "INVALID_SYNTAX";

            if (LetCommand(ScannedTokens)) isCorrect = "LET_COMMAND";
            else if (PrintCommand(ScannedTokens)) isCorrect = "PRINT_COMMAND";
            else if (InputCommand(ScannedTokens)) isCorrect = "INPUT_COMMAND";
            else if (IfCommand(ScannedTokens)) isCorrect = "IF_COMMAND";
            else if (WhileCommand(ScannedTokens)) isCorrect = "WHILE_COMMAND";
            
            return isCorrect;
        }
    }
}
