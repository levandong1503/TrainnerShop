using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.TrannerShop.Products;

public class ProductSeedDateContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Product, Guid> repository;

    public ProductSeedDateContributor(IRepository<Product, Guid> bookRepository)
    {
        repository = bookRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await repository.GetCountAsync() <= 0)
        {
            await repository.InsertAsync(
                new Product
                {
                    Name = "GIÀY MLB BIGBALL CHUNKY ",
                    Category = ProductType.RunningShoe,
                    Description = "MLB là một thương hiệu thời trang được nhiều bạn trẻ cực kỳ yêu thích trong những năm gần đây vì những phụ kiện, trang phục thời trang vô cùng cá tính và nổi bật.",
                    Price = 2000000
                },
                autoSave: true
            );

            await repository.InsertAsync(
                new Product
                {
                    Name = "Adidas Yeezy 700 ",
                    Category = ProductType.RunningShoe,
                    Description = "Tiếp theo chính là đôi giày Adidas Yeezy 700 – Đôi giày được thiết kế và ra mắt để hưởng ứng trào lưu Dad Shoe đang được các Celebrity lăng xê hiện nay.",
                    Price = 2300000
                },
                autoSave: true
            );
        }
    }
}

