using System;

/*
EXERCÍCIO: Fatorial
Descrição:
Leia um inteiro n (>=0) e calcule n!. Use long para segurança.

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
        Console.Write("Enter a non-negative integer: ");
        string input = Console.ReadLine() ?? "";
        bool sucess = int.TryParse(input, out int n);
        string seq = "";
        long res = 1;
        
        if (!sucess)
        {
            Console.WriteLine("This entry is not valid.");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("0! = 1");
        }

        for (int i = n; i <= n; i--)
        {
            res *= i;

            if (seq == "")
            {
                seq += i;
            }
            else
            {
                seq += " * " + i;
            }

            if (i == 1)
            {
                break;
            }
        }

    
        Console.WriteLine($"{n}! = {seq} = {res}");
        Console.WriteLine(fatorial(n));
    
    }

    public static int fatorial(int n)
    {
        if (n == 0 || n == 1) { return 1; }
        else { return n * fatorial(n - 1);  }
    }
}
