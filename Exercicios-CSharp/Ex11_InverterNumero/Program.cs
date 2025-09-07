using System;

/*
EXERCÍCIO: Inverter número inteiro
Descrição:
Leia um inteiro positivo e imprima seus dígitos invertidos (ex.: 1234 -> 4321).

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
        Console.Write("Write a non-negative integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            long reversed = 0;
            int n = number;

            while (n != 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }

            Console.WriteLine(reversed);
        } else
        {
            Console.Write("Invalid input.");
        }
    }
}
