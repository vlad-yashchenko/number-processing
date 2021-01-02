using System;
using System.Collections.Generic;

namespace NumberProcessing
{
     public class Program
     {
        public static void Main(string[] args)
        {
			// 1. Check quantity >= 1
			// 2. TryParse
			// 3. args
			// 4. comment

			Console.Write("How many numbers will there be? ");

			int quantity;
			while (!int.TryParse(Console.ReadLine(), out quantity))
			{
				Console.Write("Invalid input.How many numbers will there be? ");
			}

			var container = new List<int>();

			for (var i = 0; i < quantity; i++)
			{
				Console.Write($"Insert the number #{i + 1}: ");
				var input = Console.ReadLine();
				var parsed = int.Parse(input);
				container.Add(parsed);
				/*container.Add(int.Parse(Console.ReadLine()));*/
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
