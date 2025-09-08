using System;

/*
EXERCÍCIO: Função IsPrime(n)
Descrição:
Implemente função que retorna true se n for primo (teste até sqrt(n)).

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
        Console.Write("Write a number: ");
        string input = Console.ReadLine() ?? "";

        if (!long.TryParse(input, out long n))
        {
            Console.WriteLine("This entry isnt valid.");
            return;
        }
        if (n <= 1)
        {
            Console.WriteLine("Not prime.");
            return;
        }
        if (n == 2 || n == 3)
        {
            Console.WriteLine("Prime.");
            return;
        }
        if (n % 2 == 0)
        {
            Console.WriteLine("Not Prime.");
            return;
        }

        double x = n / 2.0;
        double epsilon = 1e-12;

        do
        {
            double tmp = (x + n / x) / 2.0;
            if (Math.Abs(tmp - x) < epsilon) { x = tmp; break; }
            x = tmp;

        } while (true);

        long limit = (long)Math.Floor(x);
        for (long i = 3; i <= limit; i += 2) { if (n % i == 0) { Console.WriteLine("Not prime."); return; }}

        Console.WriteLine("Prime.");
        
       
    }
}
