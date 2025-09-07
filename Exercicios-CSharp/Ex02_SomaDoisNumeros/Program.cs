using System;

/*
EXERCÍCIO: Soma de dois números
Descrição:
Leia dois números inteiros e mostre a soma.

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
        int n1, n2, sum;

        Console.WriteLine("Digite um número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        sum = n1 + n2;
        Console.WriteLine("A soma dos dois números é: " + sum);
        Console.ReadLine();
    }
}
