using System;

/*
EXERCÍCIO: Calculadora simples
Descrição:
Leia dois números e um operador (+ - * /) e mostre o resultado. Trate divisão por zero.

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
        double n1, n2, res;

        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Write the first number: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write the second number: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose an operator (+ - * /): ");
        string op = Console.ReadLine();

        if (op == "+")
        {
            res = n1 + n2;
            Console.WriteLine($"Result: {res}");
        } else if (op == "-") 
        {
            res = n1 - n2;
            Console.WriteLine($"Result: {res}");
        }
        else if (op == "*")
        {
            res = n1 * n2;
            Console.WriteLine($"Result: {res}");
        }
        else if (op == "/")
        {
            if (n2 == 0)
            {
                Console.WriteLine("Not possible to divide bt zero.");
            }
            else
            {
                res = n1 / n2;
                Console.WriteLine($"Result: {res}");
            }
        }
        else
        {
            Console.WriteLine("Invalid operator.");
        }
        Console.WriteLine("End of program.");
    }
}
