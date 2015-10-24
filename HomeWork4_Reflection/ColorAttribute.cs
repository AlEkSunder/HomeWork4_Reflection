using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Reflection
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute:System.Attribute
    {
        private ConsoleColor _color;
        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
        }
        public ColorAttribute(ConsoleColor color)
        {
            _color = color;
        }

    }
}
