using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{

	public class OfferService
	{
		private List<Product> inventory = new List<Product>() {
		new Product(){ ProductName ="P1", Price=1000, Description="P1 desc"},
		new Product(){ ProductName ="P2", Price=2000, Description="P2 desc"},
		new Product(){ ProductName ="P3", Price=3000, Description="P3 desc"},
		new Product(){ ProductName ="P4", Price=4000, Description="P4 desc"},
		new Product(){ ProductName ="P5", Price=5000, Description="P5 desc"},
		new Product(){ ProductName ="P6", Price=6000, Description="P6 desc"},
		};
		public async Task<List<Product>> GetAllProducts()
		{
			return inventory;
		}
		public async Task<List<Product>> GetTodaysOffersLowestPrice()
		{
			return inventory.OrderBy(o => o.Price).Take(3).ToList();
		}

		//public async Task<List<Product>> GetTodaysOffers()
		//{
		//	return inventory.Take(3).ToList();
		//}

		public async Task<Offer> GetTodaysOffers()
		{
			Offer offer = new Offer() { OfferName = "Today offer" };
			offer.products = new List<Product>();
			offer.products = inventory.Take(3).ToList();
			return offer;
		}

		public async Task<string> AddProduct(Product request)
		{
			List<Product> products = inventory;
			products.Add(request);
			return "Product Added successfully.";
		}
	}
}