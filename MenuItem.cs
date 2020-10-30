using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCAzureWebApi
{
    public class MenuItem
    {
        [Key]

        public int Menucode { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public bool active { get; set; }
        public DateTime date_of_launch { get; set; }
    
        public int CategoryId { get; set; }
        // public string CategoryName { get; set; }
        public bool freeDelivery { get; set; }
       
    }
}
