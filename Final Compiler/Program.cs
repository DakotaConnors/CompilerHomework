using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyCompiler
{
    class Program
    {
        static Scanner scanner = new Scanner();
        static Parser parser = new Parser();
        static ScreenUpdater updater = new ScreenUpdater();

        static bool singleLine = true;
        static int currentLine = 0;

        static bool Scan(string input, Scanner scanner, List<string> ScannedTokens)
        {
            string[] tokens = input.Split(' ');
            int whichToken = 0;
            bool areTokens = true;
            foreach(string token in tokens)
            {
                string answer = scanner.isToken(token);
                ScannedTokens.Add(answer);
                if (answer == "INVALID_TOKEN")
                {
                    areTokens = false;
                    whichToken++;
                }

                else whichToken++;
            }
            foreach (string s in ScannedTokens)
            {
                //Console.WriteLine(s);
            }
            return areTokens;
        }

        static string GrammarParser(Parser parser, List<string> ScannedTokens)
        {
            string answer = parser.CheckSyntax(ScannedTokens);
            return answer;
        }

        static string nextLine(List<string> codeLines)
        {
            string line;
            if (currentLine < codeLines.Count())
            {
                line = codeLines[currentLine];
                currentLine++;
            }
            else line = "DONE";
            return line;
        }

        static void HandleCommand(string input, string command, List<Variable> variables, List<string> infoLines, List<string> codeLines)
        {
            VariableChecker checker = new VariableChecker();

            if (command == "LET_COMMAND")
            {
                //Console.WriteLine("Handling let command");
                string[] tokens = input.Split(' ');

                Variable tempVariable;
                //Console.WriteLine("COUNT " + input);

                string type;
                if (tokens[3].StartsWith(Convert.ToString('"'))) type = "string";
                else type = "int";

                bool found = false;
                int i = 2, num, ttl = 0;
                char op;

                if (type == "int")
                {
                    while (i < tokens.Length - 1)
                    {
                        op = tokens[i][0];

                        if (checker.IsVariable(variables, tokens[i + 1])) num = checker.CheckVariableInt(variables, tokens[i + 1]);
                        else num = Convert.ToInt32(tokens[i + 1]);

                        if (op == '=')
                        {
                            ttl = num;
                        }

                        else if (op == '+')
                        {
                            ttl += num;
                        }

                        else if (op == '-')
                        {
                            ttl -= num;
                        }

                        else if (op == '*')
                        {
                            int temp1, temp2;
                            if (checker.IsVariable(variables, tokens[i - 1])) temp1 = checker.CheckVariableInt(variables, tokens[i - 1]);
                            else temp1 = Convert.ToInt32(tokens[i - 1]);
                            ttl -= temp1;
                            temp2 = temp1 * num;
                            //infoLines.Add("Temp1 " + Convert.ToString(temp1));
                            //infoLines.Add("Token " + tokens[i - 1]);
                            //infoLines.Add("Num " + Convert.ToString(num));
                            //infoLines.Add("Temp2 " + Convert.ToString(temp2));
                            ttl += temp2;
                        }

                        else if (op == '/')
                        {

                        }

                        i += 2;
                    }
                }


                foreach (Variable v in variables) //Checking if variable already exists
                {
                    if (v.name == tokens[1])
                    {
                        found = true;
                        
                        if (v.type == "int")
                        {
                            v.INT_VAL = ttl;
                        }

                        else if (v.type == "string")
                        {
                            v.STRING_VAL = tokens[3];
                        }
                    }
                }

                if (!found) //Creating new variable
                {
                    if (type == "int")
                    {
                        tempVariable = new Variable(tokens[1], type, ttl);
                        variables.Add(tempVariable);
                    }

                    else if (type == "string")
                    {
                        string temp = tokens[3].Remove(0, 1);
                        tempVariable = new Variable(tokens[1], type, temp.Remove(temp.Length - 1, 1));
                        variables.Add(tempVariable);
                    }
                }
            }

            else if (command == "PRINT_COMMAND")
            {
                //Console.WriteLine("Handling print command");
                string[] tokens = input.Split(' ');
                foreach(Variable v in variables)
                {
                    if (v.name == tokens[1] && v.type == "string") infoLines.Add((v.STRING_VAL));
                    else if (v.name == tokens[1] && v.type == "int") infoLines.Add(Convert.ToString(v.INT_VAL));
                }
            }

            else if (command == "INPUT_COMMAND")
            {
                Console.SetCursorPosition(0, 21);
                Console.Write(">>");
                string userInput = Console.ReadLine();
                string[] tokens = input.Split(' ');

                bool found = false;

                if (userInput[0] != '"')
                {
                    foreach (Variable v in variables) //Checking if variable already exists
                    {
                        if (v.name == tokens[1].Remove(0, 1))
                        {
                            //Console.WriteLine("Found variable" + v.name + " " + v.type);
                            if (v.type == "int")
                            {
                                v.INT_VAL = Convert.ToInt32(userInput);
                            }

                            else if (v.type == "string")
                            {
                                v.STRING_VAL = userInput;
                            }
                        }
                    }
                }

                else
                {
                    string fileName = userInput.Remove(0,1);
                    fileName = fileName.Remove(fileName.Count() - 1, 1);
                    singleLine = false;

                    StreamReader reader = new StreamReader(fileName);
                    while(!reader.EndOfStream)
                    {
                        string readline = reader.ReadLine();
                        codeLines.Add(readline);
                    }

                    codeLines.RemoveAt(0);

                    List<string> ScannedTokens = new List<string>();
                    string current = nextLine(codeLines);

                    while (current != "DONE")
                    {
                        ScannedTokens = new List<string>();
                        Console.Clear();
                        if (Scan(current, scanner, ScannedTokens))
                        {
                            command = GrammarParser(parser, ScannedTokens);
                            if (command != "INVALID_SYNTAX")
                            {
                                HandleCommand(current, command, variables, infoLines, codeLines);
                            }
                            //Console.WriteLine("Handling line: " + current + " as: " + command);
                            //Console.ReadKey();
                        }

                        else
                        {
                            //Console.WriteLine("Did not scan correctly: " + current);
                            //Console.ReadKey();
                        }
                        current = nextLine(codeLines);
                    }
                }
            }

            else if (command == "IF_COMMAND")
            {
                bool isCorrect = false;
                string[] tokens = input.Split(' ');

                string op = tokens[2];
                string compareVar = tokens[1];
                string compareTo = tokens[3];

                //checking if "IF" statement is true/false
                foreach (Variable v in variables)
                {
                    if (v.name == compareVar)
                    {
                        if (v.type == "string")
                        {
                            if (v.STRING_VAL == compareTo) isCorrect = true;
                        }

                        else if (v.type == "int")
                        {
                            if (v.INT_VAL == Convert.ToInt32(compareTo)) isCorrect = true;
                        }
                    }
                }

                if (isCorrect)
                {
                    List<string> ListTokens = tokens.ToList();
                    for (int i = 0; i < 5; i++) ListTokens.RemoveAt(0);
                    string[] newTokens = ListTokens.ToArray();

                    string INPUT = "";
                    foreach (string s in newTokens) INPUT += s + " ";
                    INPUT = INPUT.Remove(INPUT.Count() - 1, 1);
                    List<string> ScannedTokens = new List<string>();

                    if (Scan(INPUT, scanner, ScannedTokens))
                    {
                        command = GrammarParser(parser, ScannedTokens);
                        if (command != "INVALID_SYNTAX")
                        {
                            HandleCommand(INPUT, command, variables, infoLines, codeLines);
                        }
                    }
                }
            }

            else if (command == "WHILE_COMMAND")
            {
                string[] tokens = input.Split(' ');

                string op = tokens[2];
                string compareVar = tokens[1];
                int compareVarValue = 0;
                string compareTo = tokens[3];

                foreach (Variable v in variables) if (v.name == compareVar) compareVarValue = v.INT_VAL;

                List<string> loopCode = new List<string>();

                string newInput = "";

                if (singleLine)
                {
                    while (newInput != "END")
                    {
                        updater.UpdateScreen(codeLines, infoLines);
                        Console.SetCursorPosition(0, 21);
                        newInput = Console.ReadLine();
                        loopCode.Add(newInput);
                        codeLines.Add(newInput);
                    }
                }

                else
                {
                    while (newInput != "END")
                    {
                        newInput = nextLine(codeLines);
                        loopCode.Add(newInput);
                    }
                }
                
                while (compareVarValue == Convert.ToInt32(compareTo))
                {
                    foreach (string line in loopCode)
                    {
                        if (line != "END")
                        {
                            List<string> ScannedTokens = new List<string>();

                            if (Scan(line, scanner, ScannedTokens))
                            {
                                command = GrammarParser(parser, ScannedTokens);
                                if (command != "INVALID_SYNTAX")
                                {
                                    HandleCommand(line, command, variables, infoLines, codeLines);
                                    foreach (Variable v in variables) if (v.name == compareVar) compareVarValue = v.INT_VAL;
                                    updater.UpdateScreen(codeLines, infoLines);
                                }
                            }
                        }
                    }
                    infoLines = new List<string>() { "" };
                }
            }
        }

        static void Main(string[] args)
        {
            List<string> codeLines = new List<string>();
            List<string> infoLines = new List<string>() { "" };
            List<Variable> variables = new List<Variable>();
            bool done = false;

            List<string> ScannedTokens;

            updater.UpdateScreen(codeLines, infoLines);


            while (!done)
            {
                Console.SetCursorPosition(0, 21);
                string input = Console.ReadLine();
                ScannedTokens = new List<string>();

                if (input == "SAVE")
                {
                    Console.WriteLine("Enter File Name");
                    string fileName = Console.ReadLine();
                    StreamWriter writer = new StreamWriter(fileName);
                    foreach (string s in codeLines)
                    {
                        writer.WriteLine(s);
                        writer.Flush();
                    }
                    writer.Close();
                    updater.UpdateScreen(codeLines, infoLines);
                }

                else if (input == "CLEAR")
                {
                    codeLines = new List<string>();
                    infoLines = new List<string>() { "" };
                    variables = new List<Variable>();
                    Console.Clear();
                    updater.UpdateScreen(codeLines, infoLines);
                }

                else
                {
                    if (Scan(input, scanner, ScannedTokens))
                    {
                        string command = GrammarParser(parser, ScannedTokens);
                        if (command != "INVALID_SYNTAX")
                        {
                            codeLines.Add(input);
                            HandleCommand(input, command, variables, infoLines, codeLines);
                            updater.UpdateScreen(codeLines, infoLines);
                        }
                    }
                }
            }
        }
    }
}
