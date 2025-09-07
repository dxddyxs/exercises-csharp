using System;

/*
EXERCÍCIO: Maior e menor de um array
Descrição:
Leia N e N valores; mostre o maior e o menor.

INSTRUÇÕES:
- Implemente a lógica dentro do método Main.
- Não inclua a solução pronta neste arquivo (apenas seu código quando for resolver).
- Use este comentário/arquivo TASK.txt na pasta para lembrar o que implementar.
- Dicas (opcionais): pense em quais tipos usar, tratamento de erros e testes de borda.

TODO: Substitua esta mensagem por comentários/resolução sua quando começar a implementar.
*/

class Program {
    static void Main() {
        List<int> numbers = new List<int>();
        string input;
        int n;

        do
        {
            Console.Write("Write a integer (0 to leave): ");
            input = Console.ReadLine();

            if (int.TryParse(input, out n) && n != 0)
            {
                numbers.Add(n);
            } else if (n == 0) 
            {
                break;
            } else
            {
                Console.WriteLine("Invalid input.");
            }
        } while (true);

        if (numbers.Count > 0)
        {
            int bigger = numbers.Max();
            int smaller = numbers.Min();

            Console.WriteLine($"Numbers entered: {string.Join(", ", numbers)}");
            Console.WriteLine($"Largest number: {bigger}");
            Console.WriteLine($"Smallest number: {smaller}");
        } else
        {
            Console.WriteLine("No valid numbers entered.");
        }
    }
}
