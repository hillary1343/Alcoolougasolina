Console.Clear();

Console.WriteLine("--- Etanol ou Gasolina? ---");

double etanol;
double gasolina;

Console.WriteLine("Digite o preço do etanol (R$):");
etanol = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço da gasolina (R$):");
gasolina = Convert.ToDouble(Console.ReadLine());


Calcular();

void Calcular()
{
    double percentual = (etanol / gasolina) * 100;

    Console.WriteLine("O preço do etanol corresponde a " + percentual.ToString("n2") + "% do preço da gasolina.");

    Console.ForegroundColor = ConsoleColor.Green;
    if (percentual > 70)
    {
        Console.WriteLine("Recomendação: Abasteça com gasolina.");
    }
    else 
    {
        Console.WriteLine("Recomendação: Abasteça com etanol.");
    }
    Console.ResetColor();
}
