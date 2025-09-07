using System;
using System.Math;

/*
EXERCÍCIO: Área do círculo
Descrição:
Leia o raio (double) e calcule π * r * r (use Math.PI).

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
        double r, area;

        Console.WriteLine("Circle Area Calculator");
        Console.WriteLine("Write the circle radius: ");
        r = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * r * r;
        Console.WriteLine($"Circle area: {area}");
        Console.WriteLine("End of program.");
    }
}
