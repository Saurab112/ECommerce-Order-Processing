using Microsoft.AspNetCore.Mvc;
using Simple_Ecommerce_Application.Models;

namespace Simple_Ecommerce_Application.Controllers
{
	public class OrderController : Controller
	{
		[Route("/order")]
		[HttpPost]
		public IActionResult Index([Bind(nameof(Order.OrderDate), nameof(Order.InvoicePrice), nameof(Order.Products))] Order order) 
		{
			if(!ModelState.IsValid)
			{
				string messages = string.Join("\n", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
				return BadRequest(messages);
			}
			Random random = new Random();
			int randomOrderNumber = random.Next(1, 99999);

			return Json(new { orderNumber = randomOrderNumber });
		}
	}
}
