using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrRational
{
    class rational
    {
        private int a, b;
        
        public rational(): base()
        {
            a = 1; b = 1;
        }

        public rational(int a)
        {
            this.a = a;
            this.b = 1;
        }
        public rational(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Numitorul nu poate fi 0");
            }
            this.a = a;
            this.b = b; 
        }

        public int Numarator
        {
            get { return a; }
        }

        public int Numitor
        { 
            get { return b; }
        }

        public static rational operator + (rational x,rational y)
        {
            rational s = new rational();
            numitorCom(x, y);
            s.a = x.a + y.a;
            s.b = x.b;
            return s;
        }

        public static rational operator - (rational x, rational y)
        {
            rational s = new rational();
            numitorCom(x, y);
            s.a = x.a - y.a;
            s.b = x.b;
            return s;
        }

        public static rational operator * (rational x, rational y)
        {
            rational p = new rational();
            p.a = x.a * y.a;
            p.b = x.b * y.b;
            p = p.Simplifica();
            return p;

        }

        public static rational operator / (rational x, rational y)
        {
            rational p = new rational();
            p.a = x.a * y.b;
            p.b = x.b * y.a;
            p = p.Simplifica();
            return p;
        }

        public static rational operator ^ (rational x, int pow)
        {
            rational p = new rational();
            for (int i = 0; i < pow; i++)
            {
                p *= x; 
            }
            return p;
        }

        public static bool operator == (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a == y.a;
        }

        public static bool operator != (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a != y.a;
        }

        public static bool operator < (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a < y.a;
        }

        public static bool operator > (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a > y.a;
        }

        public static bool operator <= (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a <= y.a;
        }

        public static bool operator >= (rational x, rational y)
        {
            numitorCom(x, y);
            return x.a >= y.a;
        }

        public override bool Equals(object value)
        {
            rational r = value as rational;
            return (a == r.a) && (b == r.b);
        }

        public override int GetHashCode()
        {
            return string.Format("{0}_{1}", a, b).GetHashCode();
        }

        public rational Simplifica()
        {
            rational n = new rational();
            int c = cmmdc(a, b);
            n.a = a / c;
            n.b = b / c;
            return n;
        }

        public static void numitorCom(rational x, rational y)
        {
            int NumC = cmmmc(x.b, y.b);
            x.a *= NumC / x.b;
            y.a *= NumC / y.b;
            x.b = NumC;
            y.b = NumC;
        }

        public override string ToString()
        {
            string nr;
            nr = a.ToString() + "/" + b.ToString();
            return nr;
        }
        private static int cmmdc(int a, int b)
        {
            int nr1 = a;
            int nr2 = b;
            while(nr1 != nr2)
            {
                if (nr1 > nr2) nr1 -= nr2;
                else nr2 -= nr1;
            }
            return nr1;
        }

        private static int cmmmc(int a, int b)
        {
            return ((a * b) / cmmdc(a, b));
        }
    }
}
