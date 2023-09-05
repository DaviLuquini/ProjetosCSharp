using System;

namespace TarefaQuatro {
    class ExecFunc {
        public static void ExecutarFuncionario() {
            Funcionario f1;
            f1  = new Funcionario();
            

            Console.WriteLine("Digite seu nome:");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Digite seu Salario Bruto:");
            f1.salarioBruto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Imposto:");
            f1.imposto = int.Parse(Console.ReadLine());

            double salarioLiquido = f1.salarioLiquido(f1.salarioBruto, f1.imposto); 

            string imprimir = f1.ToString();
            Console.WriteLine(imprimir);

            Console.WriteLine("Digite a porcentagem para aumentar o Salario:");
            double porcentagem = int.Parse(Console.ReadLine());

            double salarioAtualizado = f1.aumentarSalario(porcentagem, f1.salarioBruto, salarioLiquido);

            Console.WriteLine($"Dados Atualizados " +
                $"Funcionario: {f1.nome}, Salario ${salarioAtualizado}");
        }
    }
}
