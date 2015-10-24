using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hm = new Human("Вася", "Петечкин");
            Animal am = new Animal("Кот", "Матроскин");
            Printer pr = new Printer();
            pr.ColorPrint(hm);
            pr.ColorPrint(am);
        }
    }
}
