using System;
using System.Collections.Generic;
using System.Text;

namespace ex2_classe_obj {
    class Funcionario {
        
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            porcentagem = porcentagem / 100;
            double adicionar = SalarioBruto * porcentagem;
            SalarioBruto = SalarioLiquido() + adicionar;
        }

        public override string ToString() {
            return "Funcionario: " + Nome + ", R$" + SalarioLiquido();
         }

    }
}
