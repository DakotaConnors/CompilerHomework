using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompiler
{
    class ScreenUpdater
    {
        public void UpdateScreen(List<string> codeLines, List<string> infoLines)
        {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (i < 20)
                {
                    if (i < codeLines.Count()) Console.WriteLine(codeLines[i]);
                    else Console.WriteLine();
                }
                else if (i == 20) Console.WriteLine("------------------------------------------");
                else
                {
                    if (i - 21 < infoLines.Count()) Console.WriteLine(infoLines[i - 21]);
                }
            }
            Console.SetCursorPosition(0, codeLines.Count());
        }
    }
}
