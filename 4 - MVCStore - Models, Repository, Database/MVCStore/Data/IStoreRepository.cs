﻿using MVCStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStore.Data
{
	public interface IStoreRepository
	{
		IQueryable<Product> Products { get; }
	}
}
