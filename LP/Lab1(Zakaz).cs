using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Zakaz
    {
        public void ie()
        {
            Console.WriteLine("INPUT ERROR");
        }
        //автореализуемые поля
        private int Number;
        public int number
        {
            get { return Number; }
            set
            {
                try { Number = value; if (Number < 0) { Number = 0; throw new Exception(); } }
                catch (Exception)
                {
                    ie();
                }
            }
        }
        private double Cost;
        public double cost
        {
            get { return Cost; }
            set
            {
                try { Cost = value; if (Cost < 0) { cost = 0; throw new Exception(); } }
                catch (Exception)
                {
                    ie();
                }
            }
        }
        public string code { get; set; }
        private DateTime dateOut { get; set; }
        private DateTime dateIn { get; set; }
        //конструктор по умолчанию
        public Zakaz()
        {
            string temp = "01/01/0001";
            number = 0;
            dateIn = DateTime.Parse(temp);
            dateOut = DateTime.Parse(temp);
            cost = 0;
            code = "";
        }
        //конструктор с параметром
        public Zakaz(int num, string cod)
        {
            number = num;
            dateIn = DateTime.Parse("01/01/0001");
            dateOut = DateTime.Parse("01/01/0001");
            code = cod;
            cost = 0;
        }
        //input
        public Zakaz read()
        {
            while (number == 0)
            {
                try
                {
                    Console.WriteLine("num");
                    this.number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    ie();
                }
            }
            while (cost == 0)
            {
                try
                {
                    Console.WriteLine("cost");
                    this.cost = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    ie();
                }
            }
            Console.WriteLine("code");
            this.code = Console.ReadLine();
            while (this.dateIn.Year == 1 || this.dateOut.Year == 1)
                try
                {
                    Console.WriteLine("dateIn");
                    this.dateIn = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("dateOut");
                    this.dateOut = DateTime.Parse(Console.ReadLine());
                    if (this.dateIn.CompareTo(this.dateOut) > 0) { this.dateOut = DateTime.Parse("01/01/0001"); throw new Exception(); }
                }
                catch (Exception)
                {
                    ie();
                }
            return this;
        }

        public override string ToString()
        {
            return (number.ToString() + ' ' + cost.ToString() + ' ' + code + ' ' + dateIn + ' ' + dateOut + '\n');
        }
        public void sum(Queue<Zakaz> qe)
        {
            var codeGroups = from zakaz in qe group zakaz by zakaz.code;
            foreach (IGrouping<string, Zakaz> g in codeGroups)
            {
                Console.WriteLine(g.Key + "код исполнителя");
                double sum = 0;
                foreach (var t in g)
                {
                    sum += t.cost;
                }
                Console.WriteLine(sum);
            }

        }
    }
}
