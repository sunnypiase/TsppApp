using TsppAPI.Models;

namespace TsppApp.ViewModel.Abstract
{
    internal interface IViewModel<TModel>
        where TModel : class, IEntity
    {
        public TModel GetBaseModel();
    }
}
