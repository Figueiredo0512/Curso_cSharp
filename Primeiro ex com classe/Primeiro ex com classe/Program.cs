﻿using System;

namespace Primeiro_ex_com_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            //velha.

            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");
            if(a.Idade > b.Idade)
                Console.WriteLine(a.Nome);
            else
                Console.WriteLine(b.Nome);


        }
    }
}
