using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Repositories
{
    public interface IRepository<TEntity>
    {
        Task InsertAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
        Task<List<TEntity>> GetAllPagenatedAsync(Expression<Func<TEntity, bool>> exp, int pageIndex, int pageSize, params string[] includes);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
        Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
        void Remove(TEntity entity);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);

    }
}
