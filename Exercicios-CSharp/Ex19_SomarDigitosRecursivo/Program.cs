using System;
using System.Diagnostics.CodeAnalysis;

/*
EXERCÍCIO: Somar dígitos recursivamente
Descrição:
Função que soma os dígitos de um número até resultar em um único dígito (digital root variant).

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

        Console.WriteLine(root(942));
    }

    public static int root(int n)
    {
        if (n < 10)
        {
            return n;
        }

        int sum = 0;

        while (n > 0)
        {
            sum = sum + (n % 10);
            n = n / 10;
        }

        return root(sum);
    }
}
