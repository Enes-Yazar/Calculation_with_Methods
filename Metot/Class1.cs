using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisan_1
{
    class Class1
    {
        public double toplama(int s1, int s2)
        {
            int toplama;

            toplama = s1 + s2;

            return toplama ;

        }

        public int cıkarma(int s1, int s2)
        {
            int cıkarma;

            cıkarma = s1 - s2;

            return cıkarma;

        }

        public int carpma(int s1, int s2)
        {
            int carpma;

            carpma = s1 * 
                s2;

            return carpma;

        }

        public double bolme(int s1, int s2)
        {
            double bolme;

            bolme = s1 / s2;

            return bolme;

        }

        public double ort(int s1, int s2)
        {
            double ort;

            ort = (s1 + s2) / 2;
            return ort;
        }
    }
}
