using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
             * A seguir, calcule e mostre o valor da conta a pagar.
             * 
             * 1 - Cachorro quente - R$4.00
             * 2 - X-salada        - R$4.50
             * 3 - X-bacon         - R$5.00
             * 4 - Torrada Simples - R$2.00
             * 5 - Refrigerante    - R$1.50
             * 
             */

            Console.WriteLine("Entrada: Codigo - Quantidade");

            string entrada = Console.ReadLine();
            string[] vet = entrada.Split(' ');

            int cod = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);

           // Console.WriteLine("Codigo: " + cod);
           // Console.WriteLine("Quantidade: " + qtd);
            double total = 0;

            if (qtd <= 0 || cod <= 0)
                Console.WriteLine("Entre com valores reais");
            else if (cod == 1) {
                total = (double)qtd * 4.00;
                Console.WriteLine("Voce escolheu " + qtd + " Cachorro quente");
                Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
            } else if (cod == 2) {
                total = (double)qtd * 4.50;
                Console.WriteLine("Voce escolheu " + qtd + " X-salada");
                Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
            } else if(cod == 3) {
                total = (double)qtd * 5.00;
                Console.WriteLine("Voce escolheu " + qtd + " X-Bacon");
                Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
            }
            else if (cod == 4) {
                total = (double)qtd * 2.00;
                Console.WriteLine("Voce escolheu " + qtd + " Torrada simples");
                Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
            }
            else if(cod == 5){
                total = (double)qtd * 1.50;
                Console.WriteLine("Voce escolheu " + qtd + " Torrada simples");
                Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
            }
            else
                Console.WriteLine("Entre com valores reais");

        }
    }
}
