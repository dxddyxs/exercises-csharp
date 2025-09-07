using System;

/*
EXERCÍCIO: Hello, mundo personalizado
Descrição:
Peça ao usuário o nome e exiba: Olá, <nome>! Seja bem-vindo(a) ao C#.

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
        string name;
        Console.WriteLine("Digite seu nome: ");
        name = Console.ReadLine();
        Console.WriteLine("Olá, " + name + "! Seja bem-vindo(a) ao C#");
        Console.ReadLine();
    }
}
