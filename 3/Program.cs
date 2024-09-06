using System;

public class Program
{
  public static void Main()
  {
    double[] annualRevenueArray = new double[365];
    double maxRevenue = double.MinValue;
    double minRevenue = double.MaxValue;
    double totalRevenue = 0;

    int nonZeroCount = 0;
    int aboveAverageCount = 0;

    annualRevenueArray = GetAnnualRevenue(); // Supondo que já exista o método GetAnnualRevenue() 

    // Primeiro loop para encontrar o maior, menor, e somar os valores.
    for (int i = 0; i < 365; i++)
    {
      double revenue = annualRevenueArray[i];

      if (revenue == 0)
        continue;

      if (revenue > maxRevenue)
        maxRevenue = revenue;

      if (revenue < minRevenue)
        minRevenue = revenue;

      // Somar o valor total
      totalRevenue += revenue;
      nonZeroCount++;
    }

    // Cálculo da média anual
    double averageRevenue = totalRevenue / nonZeroCount;

    // Segundo loop para contar os valores acima da média
    for (int i = 0; i < 365; i++)
    {
      double revenue = annualRevenueArray[i];

      // Ignorar valor 0
      if (revenue == 0)
        continue;

      // Contar valores acima da média
      if (revenue > averageRevenue)
        aboveAverageCount++;
    }

    Console.WriteLine("Maior Receita: " + maxRevenue.ToString("C"));
    Console.WriteLine("Menor Receita: " + minRevenue.ToString("C"));
    Console.WriteLine("Média de Receita: " + averageRevenue.ToString("C"));
    Console.WriteLine("Valores acima da média: " + aboveAverageCount);
  }

  // Para fins de teste
  public static double[] GetAnnualRevenue()
  {
    Random random = new Random();
    double[] revenues = new double[365];

    for (int i = 0; i < revenues.Length; i++)
    {
      // Gerar valores aleatórios para o exemplo
      revenues[i] = random.NextDouble() * 10000;
    }

    return revenues;
  }
}