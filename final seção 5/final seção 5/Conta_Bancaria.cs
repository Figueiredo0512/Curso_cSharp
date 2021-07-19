using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace final_seção_5 {
    class Conta_Bancaria {

        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta_Bancaria() {

        }

        public Conta_Bancaria(string nome, int numero) {
            _nome = nome;
            Numero = numero;
        }


        public Conta_Bancaria(string nome, int numero, double saldo) {
            _nome = nome;
            Numero = numero;
            Saldo = saldo;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNumero(int numero) {
            Numero = numero;
        }

        public int GetNumero() {
            return Numero;
        }

        private void SetSaldo(double saldo) {
            Saldo = saldo;
        }

        public double GetSaldo() {
            return Saldo;
        }

        public void deposito(double quantia) {
            Saldo += quantia;
        }

        public void saque(double quantia) {
            Saldo -= quantia - 5.00;
        }
    }
}
