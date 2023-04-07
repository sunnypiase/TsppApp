using TsppAPI.Models;
using TsppApp.Models;
using TsppApp.Models.Filters;

namespace TsppApp.Services.Abstract
{
    internal interface IHttpClientService
    {
        public Task<TModel> PostAsync<TModel, TDto>(TDto dto)
             where TModel : class, IEntity
             where TDto : class, IDto<TModel>;
        public Task<ICollection<TModel>> GetAsync<TModel>()
            where TModel : class, IEntity;
        public Task<ICollection<TModel>> GetFilteredAsync<TModel, TFilter>(TFilter filter)
            where TModel : class, IEntity
            where TFilter : class, IFilter<TModel>;
        public Task<TModel> PutAsync<TModel, TDto>(TDto dto)
            where TModel : class, IEntity
            where TDto : class, IDto<TModel>;
        public Task<bool> DeleteAsync<TModel>(int id)
            where TModel : class, IEntity;
        public Task<TModel> GetByIdAsync<TModel>(int id)
            where TModel : class, IEntity;
        public Task<bool> AuthorizeUser(AuthorizationDto authorizationDto);
        public Task<int> GetAmountAsync<TModel>()
            where TModel : class, IEntity;
        public Task<double> GetMatrixDetermenantAsync<TModel>(MatrixDto matrixDto);
    }
}
