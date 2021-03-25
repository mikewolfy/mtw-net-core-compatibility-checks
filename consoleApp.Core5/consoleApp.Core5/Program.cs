using classLib.Core5;
using ClassLib.Core3;
using ClassLib.Standard;
using System;

namespace consoleApp.Core5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Core3Class.Write());
            Console.WriteLine(Core5Class.Write());
            Console.WriteLine(StandardClass.Write());
            Console.ReadLine();
        }
    }
}
