using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;

namespace TsppApp.ViewModel.Abstract
{
    internal interface IViewModel<TModel>
        where TModel : class, IEntity
    {
        public TModel GetBaseModel();
    }
}
