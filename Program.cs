using System;

class FatorialUnico
{
    static void Main()
    {

        Int32 num, fatorial = 1;
        string escolha;

        Console.WriteLine("Digite um número para calcular seu fatorial: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha o método de cálculo em Loop [L] ou Recursivo [R]");
        escolha = Console.ReadLine();

        switch (escolha)
        {
            case "L":
                if (num < 0)
                    Console.WriteLine("Não existe fatorial para números negativos");
                else if (num == 0)
                    Console.WriteLine("Fatorial de 0 é sempre 1");
                else
                {
                    for (int counter = num; counter >= 1; counter--)
                    {
                        fatorial = fatorial * counter;
                    }
                };

                break;

            case "R":
                if (num == 1)
                {
                    return 1;
                }
                return num * (num - 1);
                Console.WriteLine("Fatorial de " + num + " é: " + fatorial);
        }
    }
}
