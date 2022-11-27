using TsppAPI.Models;
using TsppApp.ViewModel.Abstract;

namespace TsppApp.Services.Abstract
{
    internal interface ITableViewConverter<TModel, TResult>
        where TModel : class, IEntity
        where TResult : class, IViewModel<TModel>
    {
        ICollection<TResult> Convert(ICollection<TModel> models);
    }
}
