using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_de_revisao
{
    class contas
    {
     
        public int p = 0;

        public contas()
        {

        }
        public double quad(double m)
        {
            return m * m;
        }
        public double ret(double m,double y)
        {
            return m * y;
        }
        public double tri(double m, double y)
        {
            return (m * y)/2;

        }
        public double cir(double m)
        {
            return Math.PI*m*m;

        }
    }
}
