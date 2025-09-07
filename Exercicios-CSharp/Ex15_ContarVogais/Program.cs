using System;

/*
EXERCÍCIO: Contar vogais em uma string
Descrição:
Leia uma frase e conte quantas vogais (a,e,i,o,u) aparecem (ignore maiúsc/minúsc).

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
        string[] letters = { "a", "e", "i", "o", "u" };

        Console.Write("Write a sentence: ");
        string input = Console.ReadLine();
        int cont = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (input.Substring(i, 1).Contains(letters[j]))
                {
                    cont++;
                }
                
                /*OR
                 if (input[i].ToString() == letters[j])
                 */
            }
        }

        Console.WriteLine($"the setence have {cont}.");
    }
}
