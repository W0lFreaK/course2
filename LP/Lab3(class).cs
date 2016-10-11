using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    public interface first
    {
        string Name { get; set; }
        void GetName();
        double getS();
        void readName();
    }
    public interface second
    {
        string longitude { get; set; }
        string latitude { get; set; }
        string height { get; set; }
        string width { get; set; }
        string length { get; set; }
        void readGeo();
    }
    class city : second
    {
        public string longitude { get; set; }
        public string height { get; set; }
        public string width { get; set; }
        public string latitude { get; set; }
        public string length { get; set; }
        public city()
        {
            longitude = "";
            latitude = "";
            height = "";
            width = "";
            length = "";
        }
        public void readGeo()
        {
            longitude = Console.ReadLine();
            latitude = Console.ReadLine();
            height = Console.ReadLine();
            width = Console.ReadLine();
            length = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString() + longitude +'\t' +latitude +'\t' + height +'\t'+ width +'\t'+ length;
        }
    }
    class mega : city, first, second
    {
        public string Name { get; set; }

        public mega() : base()
        {
            Name = "";
        }
        public void readName()
        {
            Name = Console.ReadLine();
        }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
        public double getS()
        {
            return Convert.ToDouble(length) * Convert.ToDouble(width);
        }
    }
    class region : first, second
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string Name { get; set; }
        public string length { get; set; }
        public void readGeo()
        {
            longitude = Console.ReadLine();
            latitude = Console.ReadLine();
            height = Console.ReadLine();
            width = Console.ReadLine();
            length = Console.ReadLine();
        }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
        public void readName()
        {
            Name = Console.ReadLine();
        }
        public double getS()
        {
            return Convert.ToDouble(length) * Convert.ToDouble(width);
        }
    }

}
