using TsppAPI.Models;
using TsppApp.Services.Abstract;
using TsppApp.ViewModel;

namespace TsppApp.Services
{
    internal class ProductViewModelConverter : ITableViewConverter<Product, ProductViewModel>
    {
        public ICollection<ProductViewModel> Convert(ICollection<Product> models)
            => models.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Amount = x.Amount,
                Weight = x.Weight,
                Price = x.Price,
                Types = string.Join(", ", x?.Types?.Select(type => type.TypeName) ?? Array.Empty<string>()),
                BaseModel = x
            }).ToList();
    }
}
