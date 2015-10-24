using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Reflection
{
    class Human
    {
        [Color(ConsoleColor.Cyan)]
        public string FirstName { get; set; }
        [Color(ConsoleColor.Red)]
        public string SecondName { get; set; }
        public Human(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
