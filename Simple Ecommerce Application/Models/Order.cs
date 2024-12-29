using System.ComponentModel.DataAnnotations;

namespace Simple_Ecommerce_Application.Models
{
	public class Order
	{
		[Display(Name = "Order Number")]
		public int OrderNo { get; set; } 

		[Required(ErrorMessage = "Order date is required.")]
		[DataType(DataType.Date)]
		[CustomValidation(typeof(Order), nameof(ValidateOrderDate))]
		public DateTime OrderDate { get; set; }


		[Required(ErrorMessage = "{0} can't be blank")]
		[Display(Name = "Invoice Price")]
		[Range(1, double.MaxValue, ErrorMessage = "{0} should be between a valid number")]
		public double InvoicePrice { get; set; }


		[Required(ErrorMessage = "At least one product is required.")]
		public List<Product> Products { get; set; } = new List<Product>();

		// Custom Date Validation
		public static ValidationResult ValidateOrderDate(DateTime orderDate, ValidationContext context)
		{
			if (orderDate < new DateTime(2000, 1, 1))
			{
				return new ValidationResult("Order date must be on or after January 1, 2000.");
			}
			return ValidationResult.Success;
		}
	}
}
