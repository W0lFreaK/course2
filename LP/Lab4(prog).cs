using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure temp = new Figure();
            React first = new React();
            temp.RawS += first.Message1;
            temp.RawV += new Figure.v0(first.Message2);
            temp.read();
            Console.WriteLine(temp.calculate());

        }
    }
}
