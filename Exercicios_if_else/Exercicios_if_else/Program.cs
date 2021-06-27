using System;

namespace Exercicios_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Console.WriteLine("Exercicio dizendo se o numero eh negativo ou positivo");

            Console.Write("Entre com um numereo inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("O numero " + num + " eh negativo");
            else if(num > 0)
                Console.WriteLine("O numero " + num + " eh positivo");
            else
                Console.WriteLine("O numero = 0");
        }
    }
}
