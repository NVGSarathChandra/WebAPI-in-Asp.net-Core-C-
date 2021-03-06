﻿using FirstWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebAPI.Data
{
    public class ProductsDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext>dbContextOptions) : base(dbContextOptions)
        {
                
        }

    }
}
