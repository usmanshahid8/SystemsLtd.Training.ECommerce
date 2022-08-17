﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Repository
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext(DbContextOptions <ECommerceDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
