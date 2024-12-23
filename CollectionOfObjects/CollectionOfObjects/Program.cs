using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace CollectionOfObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>();

			string choice;
			do
			{
				try
				{
					Console.WriteLine("Enter value of product id");
					int pid = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter name of the product");
					string pname = Console.ReadLine();
					Console.WriteLine("Enter the price of the product");
					double pprice = double.Parse(Console.ReadLine());
					Console.WriteLine("Enter the date of manufacture(yyyy-mm-dd)");
					DateTime dom = DateTime.Parse(Console.ReadLine());
					//create new object of product class
					Product product = new Product() { ProductID = pid, ProductName = pname, Price = pprice, DateOfManufacture = dom };
					//add product object to the collection
					products.Add(product);
					Console.WriteLine("Product Added");

				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid input. Please enter the correct format");
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}

				

				//ask user whether to continue or not
				Console.WriteLine("Do you want to continue to the next product(Yes/No)");
				choice = Console.ReadLine();
			} while (choice != "No" && choice != "no" && choice != "n" && choice != "N");

			foreach(Product product in products)
			{
				Console.WriteLine(product.ProductID + " "+ product.ProductName + " " + product.Price + " " + product.DateOfManufacture.ToShortDateString());
			}
		}
	}
}