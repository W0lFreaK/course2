using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{

    class Program
    {
        public delegate void FTest();
        public delegate void STest();
        public delegate void TTest();
        static void Main(string[] args)
        {
            city a = new city();
            FTest ReadGeoF = new FTest(a.readGeo);
            mega b = new mega();
            STest ReadGeoS = new STest(b.readGeo);
            STest ReadNameS = new STest(b.readName);
            region c = new region();
            TTest ReadGeoT = new TTest(c.readGeo);
            TTest ReadNameT = new TTest(c.readName);
            TTest Sum;
            Sum = ReadGeoT + ReadNameT;
        }
    }
}

