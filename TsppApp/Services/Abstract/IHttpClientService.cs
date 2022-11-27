using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;

namespace TsppApp.Services.Abstract
{
    internal interface IHttpClientService
    {
        public Task<IEnumerable<IEntity>> GetAsync();
        public Task<IEntity?> GetByIdAsync(int id);
        public Task<bool> InsertAsync(IEntity entity);
        public Task<bool> UpdateAsync(IEntity entityToUpdate);
        public Task<bool> DeleteAsync(int id);
    }
}
