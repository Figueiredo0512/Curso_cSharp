using System;

namespace Exercicio_while_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de
             *  senha
                incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente 
                deve ser
                impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o 
                valor 2002.
              */

            int senha = 2002;

            Console.WriteLine("Digite a senha: ");
            int x = int.Parse(Console.ReadLine());

            while (x != senha)
            {
                Console.WriteLine("Senha invalida");
                x = int.Parse(Console.ReadLine());
                if (x == senha)
                    Console.WriteLine("Acesso permitido");
            }
        }
    }
}
