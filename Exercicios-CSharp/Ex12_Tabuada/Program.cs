using System;

/*
EXERCÍCIO: Tabuada
Descrição:
Leia um número e imprima a tabuada de 1 a 10.

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

        if (int.TryParse(input, out int number) && number > 0)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        } else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
