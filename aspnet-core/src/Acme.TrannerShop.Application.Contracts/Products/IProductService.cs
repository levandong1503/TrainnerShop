using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.TrannerShop.Products;

public interface IProductService : ICrudAppService<
        ProductDto, // dto hien thi san pham
        Guid, // key
        PagedAndSortedResultRequestDto, //sort and paging
        CreateUpdateProductDto>  // dto cap nhat san pham
{

}
