using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;

namespace TsppApp.Models.Filters
{
    public class ProductFilter : IFilter<Product>
    {
        public double price { get; set; }
    }
}
