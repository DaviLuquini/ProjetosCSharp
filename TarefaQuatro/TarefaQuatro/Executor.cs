using System;
using TarefaQuatro;

namespace TarefaQuatro {
    class Executor {
        static void Main(string[] args) {
            Console.WriteLine("Qual projeto você quer testar?");
            Console.WriteLine("Projeto dos Alunos digite (1) ");
            Console.WriteLine("Projeto dos Funcionários digite (2) ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                ExecAluno.ExecutarAluno();
            }
            else if (opcao == 2) {
                ExecFunc.ExecutarFuncionario();
            }
            else {
                Console.WriteLine("Opção inválida");
            }
        }


    }
}
