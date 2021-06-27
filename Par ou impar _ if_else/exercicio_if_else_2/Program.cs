using System;

namespace exercicio_if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Digite um numero para saber se eh par ou impar");
            
            int num = int.Parse(Console.ReadLine());
            
            if((num % 2) == 0)
                Console.WriteLine("o numero eh par");
            else
                Console.WriteLine("O numero eh impar");

        }
    }
}
