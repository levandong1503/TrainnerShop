using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.TrannerShop.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Category { get; set; }
        public int Price { get; set; }
    }
}
