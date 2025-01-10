using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		//// LINQ Query to get even numbers
		//var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

		//Console.WriteLine("Even Numbers:");
		//foreach (var number in evenNumbers)
		//{
		//	Console.WriteLine(number);
		//}

		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// LINQ Query 1: Get even numbers and sort them in descending order
		var evenNumbers = numbers
			.Where(n => n % 2 == 0) // Filter even numbers
			.OrderByDescending(n => n) // Sort in descending order
			.ToList();

		Console.WriteLine("Even Numbers (Descending):");
		foreach (var number in evenNumbers)
		{
			Console.WriteLine(number);
		}

		// LINQ Query 2: Get numbers greater than 5, multiply them by 2, and sort
		var transformedNumbers = numbers
			.Where(n => n > 5) // Filter numbers greater than 5
			.Select(n => n * 2) // Multiply each number by 2
			.OrderBy(n => n) // Sort in ascending order
			.ToList();

		Console.WriteLine("\nNumbers > 5 (Multiplied by 2 and Sorted):");
		foreach (var number in transformedNumbers)
		{
			Console.WriteLine(number);
		}

		// LINQ Query 3: Find the sum and average of numbers
		int sum = numbers.Sum(); // Calculate the sum of all numbers
		double average = numbers.Average(); // Calculate the average of all numbers

		Console.WriteLine($"\nSum of Numbers: {sum}");
		Console.WriteLine($"Average of Numbers: {average}");

		// LINQ Query 4: Group numbers by whether they are odd or even
		var groupedNumbers = numbers
			.GroupBy(n => n % 2 == 0 ? "Even" : "Odd") // Group by "Even" or "Odd"
			.ToList();

		Console.WriteLine("\nGrouped Numbers:");
		foreach (var group in groupedNumbers)
		{
			Console.WriteLine($"{group.Key} Numbers: {string.Join(", ", group)}");
		}
	}
}
