﻿namespace NumberProcessing
{
	using System;
	using System.Collections.Generic;
	public class Program
	{
		public static void Main(string[] args)
		{
			// 1. args
			// 2. comment
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("us-US");

			Console.Write("How many numbers will there be? ");

			double quantity;
			while (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
			{
				Console.Write("Invalid input.How many numbers will there be? ");
			}

			var container = new List<double>();

			for (var i = 0; i < quantity; i++)
			{
				Console.Write($"Insert the number #{i + 1}: ");
				double parsed;
				while (!double.TryParse(Console.ReadLine(), out parsed))
				{
					Console.Write("Invalid input. Insert the number #? ");
				}
				/*var input = Console.ReadLine();
				int.TryParse(input, out var parsed);*/
				container.Add(parsed);
			}
			double sum = 0;

			for (var i = 0; i < container.Count; i++)
			{
				sum = sum + container[i];
				/*sum += container[i]*/
			}
			Console.WriteLine($"Average = {sum / container.Count }");
			Console.WriteLine($"Sum = {sum}");
			/*Console.WriteLine("Sum = " + sum);*/

			double composition = 1;

			for (var i = 0; i < container.Count; i++)
			{
				composition *= container[i];
			}
			Console.WriteLine($"Composition = {composition}");
		}
	}
}