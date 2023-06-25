using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.TrannerShop.Products
{
    public class ProductService : CrudAppService< //CRUD
        Product,  // entity
        ProductDto, // tranfer dto show
        Guid, // key
        PagedAndSortedResultRequestDto, // paging and sorting
        CreateUpdateProductDto> // create, update
    { 
        public ProductService(IRepository<Product, Guid> repository)
        : base(repository)
        {

        }
    }
}
