using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// LINQ Query to get even numbers
		var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

		Console.WriteLine("Even Numbers:");
		foreach (var number in evenNumbers)
		{
			Console.WriteLine(number);
		}
	}
}
