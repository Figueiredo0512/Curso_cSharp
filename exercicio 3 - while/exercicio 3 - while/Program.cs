using System;

namespace exercicio_3___while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
            Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 
            1.Álcool 2.Gasolina 3.Diesel 4.Fim).
            Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código 
            (até que seja válido). O programa será encerrado quando o código informado for o número 4. 
            Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada 
            tipo de combustível, conforme exemplo.
             */

            int cod = int.Parse(Console.ReadLine());
            string tipo;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(cod != 4){

                if (cod == 1)
                {
                    tipo = "Alcool";
                    alcool++;
                }
                else if (cod == 2)
                {
                    tipo = "Gasolina";
                    gasolina++;
                }
                else if (cod == 3)
                {
                    tipo = "Diesel";
                    diesel++;
                }
                else {
                    Console.WriteLine("Digite um codigo valido!");
                }

                cod = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
