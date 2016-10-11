using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            mest temp;
            temp = new city();
            (temp as city).nas = "asdasd";
                       
            Console.WriteLine(temp.getClass());
            temp = new mega();            
            Console.WriteLine(temp.getClass());
            temp = new region();
            Console.WriteLine(temp.getClass());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    abstract class mest
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string height { get; set; }
        public string width { get; set; }
        public string length { get; set; }
        public abstract double getS();
        public virtual void read()
        {
            this.longitude = Console.ReadLine();
            this.latitude = Console.ReadLine();
            this.height = Console.ReadLine();
            this.width = Console.ReadLine();
            this.width = Console.ReadLine();
            this.length = Console.ReadLine();
        }
        public override string ToString()
        {
            return longitude + ' ' + latitude + ' ' + height + ' ' + width + ' ' + length + ' ';
        }
        public abstract string getClass();
         }
    class city : mest
    {
        public city()
        {
            longitude = "";
            latitude = "";
            height = "";
            width = "";
            length = "";
            nas = "";
        }
        public string nas { get; set; }
        public override double getS()
        {
            return Convert.ToDouble(width) * Convert.ToDouble(length);
        }
        public override void read()
        {
            base.read();
            nas = Console.ReadLine();
        }
        public double plotNaselenia()
        {
            return this.getS() / Convert.ToDouble(nas);
        }
        public override string ToString()
        {
            return base.ToString() + nas + ' ' + getS() + ' ' + plotNaselenia();
        }
        public override string getClass()
        {
            return ("Class City");          
        }
    }
    class mega : city
    {
        public string name { get; set; }
        public bool capital { get; set; }
        public mega() : base()
        {
            name = "";
            capital = false;
        }
        public override void read()
        {
            base.read();
            name = Console.ReadLine();
            capital = Console.ReadLine() == "YES";
        }
        public override string ToString()
        {
            return base.ToString() + name + ' ' + capital;
        }
        public override string getClass()
        {
            return ("Class Mega");
        }
    }
    class region : mest
    {
        public string capital_name { get; set; }
        public override double getS()
        {
            return Convert.ToDouble(height) * Convert.ToDouble(length);
        }
        public region()
        {
            latitude = "";
            height = "";
            width = "";
            length = "";
            longitude = "";
            capital_name = "";
        }
        public override string ToString()
        {
            return base.ToString() + capital_name;
        }
        public override string getClass()
        {
            return ("Class Region");
        }
    }

}
