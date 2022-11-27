using TsppAPI.Models;

namespace TsppApp.Models
{
    internal interface IDto<TEntity>
        where TEntity : class, IEntity
    { }
}
