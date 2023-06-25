using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.TrannerShop.Products
{
    public class CreateUpdateProductDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        
        [Required]
        public ProductType Category { get; set; }

        [Required]                
        public int Price { get; set; }
    }
}
