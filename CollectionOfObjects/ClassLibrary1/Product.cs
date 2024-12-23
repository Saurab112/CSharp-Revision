﻿namespace ClassLibrary1
{
	/// <summary>
	/// Represents a product in ECommerce application
	/// </summary>
	public class Product
	{
		public int ProductID { get; set; }
		public string? ProductName { get; set; }
		public double Price { get; set; }
		public DateTime DateOfManufacture { get; set; }
	}
}
