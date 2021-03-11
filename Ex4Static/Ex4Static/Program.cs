using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex4Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um Programa para ler a cotação do dólar, e depois um valor a ser comprado em dólar por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando uma taxa fixa de 6% de IOF em dólar. Criar uma Classe 'ConversorMoedas' para ser responsável pelos Cálculos.\n");
            Console.WriteLine("Quanto está valendo o Dolar?");
            Console.Write("Cotação: ");

            ConversorMoedas obj = new ConversorMoedas();
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você quer trocar?");
            double quant = double.Parse(Console.ReadLine());
            double conv = ConversorMoedas.Conversao(quant, cotacao); //Como meu método "Conversao" é statico, posso chama-lo sem precisar usar um Objeto, uso somente o nome da Classe.

            Console.Write("Você vai precisar de: R$ " + conv.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(" Reais para comprar: $ " + quant.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(" Dólares.");

            Console.ReadKey();



            Console.ReadKey();
        }
    }
}
