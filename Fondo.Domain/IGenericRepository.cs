using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Domain
{
    public interface IGenericRepository<TEntity,TEntityDTO> where TEntity : class where TEntityDTO : class
    {
        IEnumerable<TEntityDTO> GetAll(string[] includes=null);

        Task<TEntityDTO> GetByIdAsync(int id);
        Task<TEntityDTO> GetByIdAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> filter, string[] includes=null);

        Task CreateAsync(TEntityDTO entity);

        Task UpdateAsync(TEntityDTO entity);

        Task DeleteAsync(int id);
        IEnumerable<TEntityDTO> Get(Func<TEntity, bool> filter, string[] includes = null);


    }
}
