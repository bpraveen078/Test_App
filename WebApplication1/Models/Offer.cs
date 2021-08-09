using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Offer
	{
		public string OfferName { get; set; }
		public List<Product> products { get; set; }
	}
}
