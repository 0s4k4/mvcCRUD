﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Web;

namespace mvcCRUD.Models
{
    public class Product
    {


        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        public decimal Price { get; set; }


    }
}