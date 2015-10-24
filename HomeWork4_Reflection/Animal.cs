using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Reflection
{    
    class Animal
    {
        [Color(ConsoleColor.Blue)]
        public string Type { get; set; }
        [Color(ConsoleColor.Magenta)]
        public string Name { get; set; }
        public Animal(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
