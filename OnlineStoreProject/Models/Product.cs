using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreProject.Models
{
    public class Product
    {
        public int ID { get; set; }


        [Required]
        [MinLength(5)]
        public string Name { get; set; }


        [Range(1, float.MaxValue, ErrorMessage = "Can't be free!! ")]
        [Display(Name = "Price for one in gold coins")]
        public float Price { get; set; }


        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        public string Image { get; set; }

        
        
        [Display(Name = "Quantity")]
        public int QuantityInStoke { get; set; }    
    }
}
