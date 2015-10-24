using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HomeWork4_Reflection
{
    class Printer
    {
        public void ColorPrint(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();            
            foreach (var item in properties)
            {
                PropertyInfo prop = type.GetProperty(item.Name);
                Attribute propAttribute = prop.GetCustomAttribute(typeof(ColorAttribute));
                Console.ForegroundColor = ((ColorAttribute)propAttribute).Color;                
                Console.WriteLine(item.GetValue(obj));
                Console.ForegroundColor = ConsoleColor.Gray;          
            }
        }
    }
}
