using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzas
{

    class pizza
    {
        public string massa, tamanho;
        public int p = 0;

        public pizza()
        {

        }
        public double ver(string m, string t)
        {
            massa = m;
            tamanho = t;
            
            if (string.Compare(massa, "fina") == 0 && string.Compare(tamanho, "individual") == 0)
            {
                double total = 5.90;
                return total;
            }
            else if (string.Compare(massa, "fina") == 0 && string.Compare(tamanho, "média") == 0)
            {
                double total = 9.55;
                return total;
            }
            else if(string.Compare(massa, "fina") == 0 && string.Compare(tamanho, "familiar") == 0)
            {
                double total = 13.40;
                return total;
            }
            else if(string.Compare(massa, "pan") == 0 && string.Compare(tamanho, "individual") == 0)
            {
                double total = 6.85;
                return total;
            }
            else if(string.Compare(massa, "pan") == 0 && string.Compare(tamanho, "média") == 0)
            {
                double total = 10.65;
                return total;
            }
            else if(string.Compare(massa, "pan") == 0 && string.Compare(tamanho, "familiar") == 0)
            {
                double total = 14.65;
                return total;
            }
            else if(string.Compare(massa, "rolling") == 0 && string.Compare(tamanho, "individual") == 0)
            {
                double total = 16.00;
                return total;
            }
            else if(string.Compare(massa, "rolling") == 0 && string.Compare(tamanho, "média") == 0)
            {
                double total = 16.60;
                return total;
            }
            else if(string.Compare(massa, "rolling") == 0 && string.Compare(tamanho, "individual") == 0)
            {
                double total = 17.60;
                return total;
            }
            else
            {
                return 0;
            }

        }
        public double add(string t,int i)
        {
            tamanho = t;
            double total = i;
            if (string.Compare(tamanho, "") == 0)
            {
                double p = 0;
                return p;
            }
            if (string.Compare(tamanho, "individual") == 0)
            {
               double p = total * 1;
                return p;
            }
            else if (string.Compare(tamanho, "média") == 0)
            {
                double p = total * 1.90;
                return p;
            }
            else
            {
                double p = total * 2.30;
                return p;
            }
        }



    }
}

