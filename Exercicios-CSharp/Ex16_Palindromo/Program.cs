8using System;

/*
EXERCÍCIO: Palíndromo (string)
Descrição:
Leia uma palavra e verifique se é palíndroma (ignore caso e espaços, se quiser).

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

        Console.Write("Write a sentence: ");
        string input = Console.ReadLine() ?? "";

        string sen = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                sen += char.ToLower(input[i]);
            }
        }

        int start = 0;
        int end = sen.Length - 1;

        while (start < end)
        {
            if (sen[start] == sen[end])
            {
                start++;
                end--;
            } else
            {
                Console.WriteLine("n palindromo F");
                break;
            }

            if (start >= end)
            {
                Console.WriteLine($"Palindromo!\n{sen}");
                break;
            }
        }
    }
}
