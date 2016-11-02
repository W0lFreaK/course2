using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Events
    {
        public static void messageEx()
        {
            Console.WriteLine("Ошибка - выход за пределы массива");
        }
        public static void messageEx(String txt)
        {
            Console.WriteLine(txt);
        }
    }
}
