﻿using MVCStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStore.Data
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products
        {
            get
			{
				return new List<Product> {
	   new Product { Name = "Football", Price = 25 },
	   new Product { Name = "Surf board", Price = 179 },
	   new Product { Name = "Running shoes", Price = 95 }
		}.AsQueryable<Product>();
			}
        }
    }
}