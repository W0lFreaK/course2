using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        public static int MainMenu()
        {
            Console.WriteLine("1- Add new element \n 2 - Print element \n 3 - Sum code \n Else - Exit");
            return Convert.ToInt32(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int selection = 0;
            Queue<Zakaz> qe = new Queue<Zakaz>();
            while (true)
            {
                selection = MainMenu();
                if (selection == 1)
                {
                    Zakaz temp = new Zakaz();
                    temp.read();
                    qe.Enqueue(temp);
                }
                else
                    if (selection == 2)
                {
                    foreach (var i in qe)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                else
                    if (selection == 3)
                {
                    Zakaz temp = new Zakaz();
                    temp.sum(qe);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
