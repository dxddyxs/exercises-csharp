using System;

/*
EXERCÍCIO: Quantidade de números positivos
Descrição:
Leia N (quantidade) e N números; conte quantos são positivos.

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
        int n, amount = 0;

        Console.Write("How many numbers will you enter? ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());
            amount++;
            
            if (number < 0)
            {
                amount--;
            }
        }

        Console.WriteLine($"{amount} positive numbers");
    }
}
