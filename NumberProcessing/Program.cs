using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace NumberProcessing
{
     public class Program
     {
        public static void Main(string[] args)
        {
	        // 1. TryParse
			// 2. args
			// 3. comment

			Console.Write("How many numbers will there be? ");

			int quantity;
			while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
			{
				Console.Write("Invalid input.How many numbers will there be? ");
			}

			var container = new List<int>();

			for (var i = 0; i < quantity; i++)
			{
				Console.Write($"Insert the number #{i + 1}: ");
				int parsed;
				while (!int.TryParse(Console.ReadLine(), out parsed))
				{
					Console.Write("Invalid input. Insert the number #? ");
				}
				/*var input = Console.ReadLine();
				int.TryParse(input, out var parsed);*/
				container.Add(parsed);
			}
			int sum = 0;

			 for (var i = 0; i < container.Count; i++)
			{
				sum = sum + container[i];
				/*sum += container[i]*/
			}
			Console.WriteLine($"Average = {sum / container.Count }");
			Console.WriteLine($"Sum = {sum}");
			/*Console.WriteLine("Sum = " + sum);*/

			int composition = 1;

			for (var i = 0; i < container.Count; i++)
			{
				composition *= container[i];
			}
			Console.WriteLine($"Composition = {composition}");
		}
     }
}
