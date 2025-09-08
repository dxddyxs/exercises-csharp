using System;

/*
EXERCÍCIO: Ordenação simples (Bubble sort)
Descrição:
Implemente bubble sort para ordenar um array de inteiros e imprima o array ordenado.

INSTRUÇÕES:
- Implemente a lógica dentro do método Main.
- Não inclua a solução pronta neste arquivo (apenas seu código quando for resolver).
- Use este comentário/arquivo TASK.txt na pasta para lembrar o que implementar.
- Dicas (opcionais): pense em quais tipos usar, tratamento de erros e testes de borda.

TODO: Substitua esta mensagem por comentários/resolução sua quando começar a implementar.
*/

class Program {
    static void Main()
    {
        // TODO: implemente o exercício aqui.
        int[] array = { 5, 4, 3, 2, 1 };
        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                Console.WriteLine($"pass {i}: {string.Join(", ", array)}");
            }
        }
    }
}
