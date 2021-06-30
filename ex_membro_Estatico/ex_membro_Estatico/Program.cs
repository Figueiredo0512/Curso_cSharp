using System;
using System.Globalization;

namespace ex_membro_Estatico {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Qual a cotacao do dolar ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares vc vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Conversao(dolar, qtd);
            Console.WriteLine("Valor a se pago em R$: " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
