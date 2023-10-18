using System;
using System.Text.RegularExpressions;

Double Somar(int a, int b)
{
    return a + b;
}

Double Subtração(int a, int b)
{
    return a - b;
}

Double Divisão(int a, int b)
{
    return a / b;
}

Double Multiplicação(int a, int b)
{
    return (a * b);
}

Console.WriteLine("------------ CALCULADORA DE CONSOLE --------------------");

while (true)
{
    // Receber números para a operação
    Console.Write("Digite um número: ");
    string input1 = Console.ReadLine();

    if (!Regex.IsMatch(input1, "^[0-9]+$"))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    int a = Convert.ToInt32(input1);

    // Escolher as operações realizavéis 
    Console.Write(" \n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n \nQual operação deseja realizar? ");
    string ValidarOperador = Console.ReadLine();
    if (!Regex.IsMatch(ValidarOperador, "^[1-4]+$"))
    {
        Console.WriteLine("Operação Inválida.");
        return;
    }

    int operador = Convert.ToInt32(ValidarOperador);

    Console.Write("Digite outro número: ");
    string input2 = Console.ReadLine();

    if (!Regex.IsMatch(input2, "^[0-9]+$"))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    int b = Convert.ToInt32(input2);

    double resultado = 0;

    switch (operador)
    {

        case 1:
            resultado = Somar(a, b);
            break;
        case 2:
            resultado = Subtração(a, b);
            break;
        case 3:
            resultado = Multiplicação(a, b);
            break;
        case 4:
            resultado = Divisão(a, b);
            break;
        default:
            Console.WriteLine("Operação Inválida.");
            break;
    }
    Console.WriteLine($"O resultado da operação desejada é {resultado}");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("1 -  Fazer uma Nova operação\n0 - Parar");
    int Continuar = Convert.ToInt32(Console.ReadLine());
    if (Continuar != 1)
    {
        Console.WriteLine("Calculadora Finalizada!");
        break;
    }

}