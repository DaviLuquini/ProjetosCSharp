using System;

namespace TarefaQuatro {
    internal class Funcionario {
        public string nome;
        public double salarioBruto;
        public double imposto;


        public double salarioLiquido(double salarioBruto, double imposto) {
            double salarioLiquido = salarioBruto - imposto;
            return salarioLiquido;
        }

        public double aumentarSalario(double porcentagem, double salarioBruto, double salarioLiquido) {
            double aumento = (porcentagem / 100) * salarioBruto;
            double salarioAtualizado = salarioLiquido + aumento;
            return salarioAtualizado;
        }

        public override string ToString() {
            return $"Funcionario: {nome}, Salario Liquido: ${salarioLiquido(salarioBruto,imposto)}";
        }
    }
}
