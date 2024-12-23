using System;
using ClassLibrary1;

namespace ExtensionMethodPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product = new Product() { ProductCost = 1000, DiscountPercent = 10  };

			//calling the extension method
			Console.WriteLine(product.GetDiscount()); 
			Console.ReadKey();
		}

	}
}