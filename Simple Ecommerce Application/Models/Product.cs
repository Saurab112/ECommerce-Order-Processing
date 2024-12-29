using System.ComponentModel.DataAnnotations;

namespace Simple_Ecommerce_Application.Models
{
	public class Product
	{
		[Required(ErrorMessage = "{0} can't be blank")]

		public int ProductCode { get; set; }

		[Required(ErrorMessage = "{0} can't be blank")]
		[Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "{0} can't be blank")]
		[Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
		public int Quantity { get; set; }

	}
}
