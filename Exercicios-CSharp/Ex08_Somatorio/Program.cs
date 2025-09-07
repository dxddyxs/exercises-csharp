using System;
using System.Runtime.Serialization;

/*
EXERCÍCIO: Somatório 1..N
Descrição:
Leia N e calcule a soma 1 + 2 + ... + N usando loop.

INSTRUÇÕES:
- Implemente a lógica dentro do método Main.
- Não inclua a solução pronta neste arquivo (apenas seu código quando for resolver).
- Use este comentário/arquivo TASK.txt na pasta para lembrar o que implementar.
- Dicas (opcionais): pense em quais tipos usar, tratamento de erros e testes de borda.

TODO: Substitua esta mensagem por comentários/resolução sua quando começar a implementar.
*/

class Program {
    static void Main() {
        // TODO: implemente o exercício aqui.
        int n; 
        int sum = 0;
        string seq = "";

        Console.WriteLine("Enter an interger: ");
        string input = Console.ReadLine() ?? "";
        bool sucess = int.TryParse(input, out n);

        if (!sucess)
        {
            Console.WriteLine("Write a valid number.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            sum += i;

            if (seq == "")
            {
                seq += i;
            }
            else
            {
                seq += " + " + i;
            }
        }

        Console.WriteLine($"{seq} = {sum}");
    }
}