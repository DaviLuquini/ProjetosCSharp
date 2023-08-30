using System;


namespace TarefaTres {
    class ExecFunc {
        public static void ExecutarFuncionario() {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();
            int salarioMedio = 0;

            Console.WriteLine("Escreva o nome do Primeiro funcionario");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine("Escreva o salario do Primeiro funcionario");
            funcionario1.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o nome do Segundo funcionario");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine("Escreva o salario do Segundo funcionario");
            funcionario2.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.WriteLine("Nome: " + funcionario1.nome);
            Console.WriteLine("Salario: " + funcionario1.salario);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.WriteLine("Nome: " + funcionario2.nome);
            Console.WriteLine("Salario: " + funcionario2.salario);

            salarioMedio = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("Salario medio: " + salarioMedio);

         


        }
    }
}
