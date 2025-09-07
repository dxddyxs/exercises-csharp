using System;

/*
EXERCÍCIO: Temperatura (C → F)
Descrição:
Leia uma temperatura em Celsius (float) e converta para Fahrenheit: F = C * 9/5 + 32.

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
        double c, f;

        Console.WriteLine("Write the temperature in Celsius: ");
        c = Convert.ToDouble(Console.ReadLine());
        f = c * 9 / 5 + 32;
        Console.WriteLine("The temperature in Fahrenheit is: " + f);
        Console.ReadLine();
    }
}
