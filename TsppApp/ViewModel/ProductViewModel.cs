using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;
using TsppApp.ViewModel.Abstract;

namespace TsppApp.ViewModel
{
    internal class ProductViewModel : IViewModel<Product>
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public double Price { get; init; }
        public int Amount { get; init; }
        public double Weight { get; init; }
        public string Types { get; init; } = string.Empty;
        public Product BaseModel { private get; init; }

        public ProductViewModel(Product baseModel)
        {
            BaseModel = baseModel;
        }

        public ProductViewModel()
        {

        }
        public Product GetBaseModel() => BaseModel;
    }
}
