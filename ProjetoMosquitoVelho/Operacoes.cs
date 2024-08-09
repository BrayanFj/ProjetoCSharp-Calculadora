using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
   public class Operacoes
    {
        //metodo construtor
        public Operacoes()
        {

        }
        public double somaValor(double v1, double v2)
        {
            return (v1 + v2);
        }
        public double SubtrairValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double MultiplicarValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double DividirValor(double v1, double v2)
        {
            if (v2 != 0)
            {

                return (v1 % v2);
            }
            else
            {
                return 0;
            }

        }



    }
}
