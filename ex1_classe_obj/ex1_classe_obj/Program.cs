using System;
using System.Globalization;

namespace ex1_classe_obj {
    class Program {
        static void Main(string[] args) {
            /*
             Fazer um programa para ler os valores da largura e altura de um retângulo. Em
             seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
             como mostrado no projeto ao lado.
             */

            Retangulo x = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}
