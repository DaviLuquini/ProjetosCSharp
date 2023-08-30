

namespace TarefaTres {
    class ExecPessoa {
         public static void ExecutarPessoa() {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Escreva o nome da Primeira Pessoa");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Escreva a idade da Primeira Pessoa");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o nome da Segunda Pessoa");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Escreva a idade da Segunda Pessoa");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Idade: " + pessoa1.idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Idade: " + pessoa2.idade);

            if (pessoa1.idade > pessoa2.idade) {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }




        }

    }
}
