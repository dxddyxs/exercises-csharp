using System;

/*
EXERCÍCIO: Fibonacci N-ésimo (iterativo)
Descrição:
Leia N e mostre o N-ésimo termo (F(0)=0, F(1)=1) usando loop.

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
        Console.Write("Write a non-negative integer number: ");
        string input = Console.ReadLine();
        bool sucess = long.TryParse(input, out long n);
        string seq = "";

        if (!sucess)
        {
            Console.WriteLine("This entry is not valid.");
            return;
        }

        if (n < 0)
        {
            Console.WriteLine("This entry is not valid.");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("0");
        }

        if (n == 1)
        {
            Console.WriteLine("1");
        }

        int prev = 0; // previus
        int cur = 1; // current
        int i = 2;

        do
        {
            int next = prev + cur;
            prev = cur;
            cur = next;
            i = i + 1;

            if (seq == "")
            {
                seq += prev;
                seq += ", " + cur;
            } else
            {
                seq += ", " + cur;
            }
        } while (i <= n);

        Console.WriteLine($"{seq}");
    }
}
