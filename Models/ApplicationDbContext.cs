﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace mvcCRUD.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Product>Products {get; set;}

    }
}