﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCAzureWebApi
{
    public class Category
    {
        [Key]
      
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
    }
}
