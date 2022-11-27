using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsppAPI.Models;

namespace TsppApp.Models
{
    internal interface IDto<TEntity>
        where TEntity : class, IEntity
    { }
}
