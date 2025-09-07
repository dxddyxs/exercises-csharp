using System;

/*
EXERCÍCIO: Soma e média de array
Descrição:
Leia N valores, calcule soma e média (duas casas decimais).

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

        List<int> numbers = new List<int>();
        string input;
        int n;
        int sum = 0;

        do
        {
            Console.Write("Write a integer(0 to leave): ");
            input = Console.ReadLine();

            if (int.TryParse(input, out n) && n != 0)
            {
                numbers.Add(n);
                sum += n;
            } else if (n == 0)
            {
                Console.WriteLine("Exiting...");
                break;
            } else
            {
                Console.WriteLine("Invalid input.");
            }
        } while (true);

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum of the indices is: {sum}");
            Console.WriteLine($"The average of the indexes is: {average:F2}");
        } else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
