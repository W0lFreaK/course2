using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{


    class Figure
    {

        public delegate void s0();
        public event s0 RawS;
        public delegate void v0(int num);
        public event v0 RawV;

        const double eps = 0.00001;

        public struct point
        {
            public int x { get; set; }
            public int y { get; set; }
            public void read()
            {
                String s = Console.ReadLine();
                this.x = Convert.ToInt32(s.Split()[0]);
                this.y = Convert.ToInt32(s.Split()[1]);
            }            
        };

        point v1, v2, v3, v4;
        int num;
        public Figure()
        {
            this.v1.x = 0;
            this.v1.y = 0;
            this.v2.x = 0;
            this.v2.y = 0;
            this.v3.x = 0;
            this.v3.y = 0;
            this.v4.x = 0;
            this.v4.y = 0;
        }
        public void read()
        {
            v1.read();
            if (v1.x == 0 && v1.y == 0)
            {
                num = 1;
                RawV(num);
            }
            v2.read();
            if (v2.x == 0 && v2.y == 0)
            {
                num = 2;
                RawV(num);
            }
            v3.read();
            if (v3.x == 0 && v3.y == 0)
            {
                num = 3;
                RawV(num);
            }
            v4.read();
            if (v4.x == 0 && v4.y == 0)
            {
                num = 4;
                RawV(num);
            }
        }
        public double calculate()
        {

            double r1, r2, r3;
            r1 = Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y));
            r2 = Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y));
            r3 = Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y));
            double p = (r1 + r2 + r3) / 2;
            double sp = Math.Sqrt(p * (p - r1) * (p - r2) * (p - r3));
            r1 = Math.Sqrt((v1.x - v3.x) * (v1.x - v3.x) + (v1.y - v3.y) * (v1.y - v3.y));
            r2 = Math.Sqrt((v3.x - v4.x) * (v3.x - v4.x) + (v3.y - v4.y) * (v3.y - v4.y));
            r3 = Math.Sqrt((v1.x - v4.x) * (v1.x - v4.x) + (v1.y - v4.y) * (v1.y - v4.y));
            p = (r1 + r2 + r3) / 2;
            sp += Math.Sqrt(p * (p - r1) * (p - r2) * (p - r3));
            if (Math.Abs(sp - 1) < eps)
            {
                RawS();
            }
            return sp;
            /*   return Math.Sqrt((Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)) + Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y)) +
                Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y))) / 2 * ((Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)) + Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y)) +
                Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y))) / 2 - Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y))) * ((Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)) + Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y)) +
                Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y))) / 2 - Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y))) * ((Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)) + Math.Sqrt((v2.x - v3.x) * (v2.x - v3.x) + (v2.y - v3.y) * (v2.y - v3.y)) +
                Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y))) / 2 - Math.Sqrt((v3.x - v1.x) * (v3.x - v1.x) + (v3.y - v1.y) * (v3.y - v1.y)))) + Math.Sqrt((Math.Sqrt((v1.x - v3.x) * (v1.x - v3.x) + (v1.y - v3.y) * (v1.y - v3.y)) +
                Math.Sqrt((v3.x - v4.x) * (v3.x - v4.x) + (v3.y - v4.y) * (v3.y - v4.y)) + Math.Sqrt((v1.x - v4.x) * (v1.x - v4.x) + (v1.y - v4.y) * (v1.y - v4.y))) / 2 * ((Math.Sqrt((v1.x - v3.x) * (v1.x - v3.x) + (v1.y - v3.y) * (v1.y - v3.y)) +
                Math.Sqrt((v3.x - v4.x) * (v3.x - v4.x) + (v3.y - v4.y) * (v3.y - v4.y)) + Math.Sqrt((v1.x - v4.x) * (v1.x - v4.x) + (v1.y - v4.y) * (v1.y - v4.y))) / 2 - Math.Sqrt((v1.x - v3.x) * (v1.x - v3.x) + (v1.y - v3.y) * (v1.y - v3.y))) *
                Math.Sqrt((Math.Sqrt((v1.x - v3.x) * (v1.x - v3.x) + (v1.y - v3.y) * (v1.y - v3.y)) + Math.Sqrt((v3.x - v4.x) * (v3.x - v4.x) + (v3.y - v4.y) * (v3.y - v4.y)) + Math.Sqrt((v1.x - v4.x) * (v1.x - v4.x) + (v1.y - v4.y) * (v1.y - v4.y))) / 2 - Math.Sqrt((v1.x - v4.x) * (v1.x - v4.x) + (v1.y - v4.y) * (v1.y - v4.y))));
         */
        }
    }
}
