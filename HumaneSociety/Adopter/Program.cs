using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class Program
    {
        static void Main(string[] args)
        {
            //UI.RebuildForCursorSelectionMenu("test", "hello", "world","press enter");

            List<string> stringlist = new List<string>() { "hi", "world", "fuckinga" };
            string text = string.Join(",", stringlist);
            Console.WriteLine(text);
            Console.ReadKey();
            
        }
    }
}
