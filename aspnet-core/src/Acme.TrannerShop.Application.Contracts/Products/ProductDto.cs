using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.TrannerShop.Products
{
    public class ProductDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Category { get; set; }
        public int Price { get; set; }
    }
}
