using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorialclasses
{
    class fatorial
    {
        public int num, fator1;
        public fatorial(int numEntrada)
        {
            num = numEntrada;
            fator1 = 1;
        }
        public double Calcular()
        {
            while (num > 1)
            {
                fator1 = fator1 * num;
                num--;
            }
            return fator1;
        }

        }
}
