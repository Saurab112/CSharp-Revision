using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace ExtensionMethodPractice
{
	public static class ProductExtensionMethod
	{
		public static double GetDiscount(this Product product)
		{
			return product.ProductCost * product.DiscountPercent / 100;
		}
	}
}
