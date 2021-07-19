using System;
using System.Globalization;

namespace final_seção_5 {
    class Program {
        static void Main(string[] args) {
            string nome;
            int numero;
            double saldo, quantia;
            string yon;

            Conta_Bancaria conta = new Conta_Bancaria();

            Console.Write("Entre com o numero da conta bancaria: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Havera saldo iniciarl? S/n: ");
            yon = Console.ReadLine();


            if (yon == "S" || yon == "s") {
                Console.WriteLine("Entre com o saldo inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta_Bancaria(nome, numero, saldo);
            }

            else {
                conta = new Conta_Bancaria(nome, numero);
            }

            Console.WriteLine("\n\rDados da conta: ");
            Console.WriteLine("Nome: " + conta.GetNome() + ", Numero da conta: " + conta.GetNumero() + " Saldo: R$" + conta.GetSaldo());

            Console.WriteLine("Deposito: ");
            quantia = double.Parse(Console.ReadLine());
            conta.deposito(quantia);

            Console.WriteLine("\n\rDados da conta: ");
            Console.WriteLine("Nome: " + conta.GetNome() + ", Numero da conta: " + conta.GetNumero() + " Saldo: R$" + conta.GetSaldo());

            Console.WriteLine("Saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.saque(quantia);

            Console.WriteLine("\n\rDados da conta: ");
            Console.WriteLine("Nome: " + conta.GetNome() + ", Numero da conta: " + conta.GetNumero() + " Saldo: R$" + conta.GetSaldo());
        
        }
    }
}
