using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class InventoryController : ControllerBase
	{

		[HttpGet]
		public async Task<List<Product>> GetAllProducts()
		{
			OfferService service = new OfferService();
			List<Product> products = await service.GetAllProducts();
			return products;
		}

		[Route("api/Inventory/GetTodaysOffersLowestPrice")]
		[HttpGet]
		public async Task<List<Product>> GetTodaysOffersLowestPrice()
		{
			OfferService service = new OfferService();
			List<Product> products = await service.GetTodaysOffersLowestPrice();
			return products;
		}

		//[Route("api/Inventory/GetTodaysOffers")]
		//[HttpGet]
		//public async Task<List<Product>> GetTodaysOffers()
		//{
		//	OfferService service = new OfferService();
		//	List<Product> products = await service.GetTodaysOffers();
		//	return products;
		//}

		[Route("api/Inventory/GetTodaysOffers")]
		[HttpGet]
		public async Task<Offer> GetTodaysOffers()
		{
			OfferService service = new OfferService();
			Offer offer = await service.GetTodaysOffers();
			return offer;
		}

		[Route("api/Inventory/AddProduct")]
		[HttpPost]
		public async Task<string> AddProduct([FromBody] Product request)
		{
			OfferService service = new OfferService();
			string response = await service.AddProduct(request);
			return response;
		}
	}

}

