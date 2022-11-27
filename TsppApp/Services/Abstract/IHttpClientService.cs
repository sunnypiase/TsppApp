using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;
using TsppApp.Models;

namespace TsppApp.Services.Abstract
{
    internal interface IHttpClientService
    {
        public Task<TModel> PostAsync<TModel, TDto>(TDto dto)
             where TModel : class, IEntity
             where TDto : class, IDto<TModel>;
        public Task<ICollection<TModel>> GetAsync<TModel>()
            where TModel : class, IEntity;
        public Task<TModel> PutAsync<TModel, TDto>(TDto dto)
            where TModel : class, IEntity
            where TDto : class, IDto<TModel>;
        public Task<bool> DeleteAsync<TModel>(int id)
            where TModel : class, IEntity;
        public Task<TModel> GetByIdAsync<TModel>(int id)
            where TModel : class, IEntity;
    }
}
