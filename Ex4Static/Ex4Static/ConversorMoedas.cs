using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Static
{
    class ConversorMoedas
    {
        //--------------------[ATRIBUTOS]
        public static double IOF = 0.06;       //Atributos "static" são atributos fixos, ou seja, não mudam nunca.
        

        //--------------------[MÉTODOS]
        public static double Conversao(double quant, double cotacao)      //Atributos sempre com 1ª letra minúscula.
        {
            return (quant * cotacao) + (quant * cotacao * IOF);
        }
    }
}
