namespace NumberProcessing
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      // 1. args
      // 2. comment
      Console.Write("How many numbers should be processed? ");

      int quantity;
      while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
      {
        Console.Write("Invalid input. How many numbers should be processed? ");
      }

      var container = new List<double>();

      for (var i = 0; i < quantity; i++)
      {
        Console.Write($"Insert the number #{i + 1}: ");
        string res = Console.ReadLine();
        res = res.Replace('.', ',');
        double parsed;
        while (!double.TryParse(res, out parsed))
        {
          Console.Write($"Invalid input. Insert the number #{i + 1}: ");
        }

        container.Add(parsed);
      }
      double sum = 0;

      for (var i = 0; i < container.Count; i++)
      {
        sum += container[i];
      }
      Console.WriteLine($"Average = {sum / container.Count}");
      Console.WriteLine($"Sum = {sum}");

      double composition = 1;

      for (var i = 0; i < container.Count; i++)
      {
        composition *= container[i];
      }
      Console.WriteLine($"Composition = {composition}");
    }
  }
}
