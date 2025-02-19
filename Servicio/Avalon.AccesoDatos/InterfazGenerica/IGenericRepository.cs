using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.InterfazGenerica
{
    public interface IGenericRepository:IDisposable
    {
        TEntity Add<TEntity>(TEntity toCreate) where TEntity : class;
        bool Delete<TEntity>(TEntity toDelete) where TEntity : class;
        bool Update<TEntity>(TEntity toUpdate) where TEntity : class;
        TEntity Get<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;
        List<TEntity> GetAllByCritearia<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;
        List<TEntity> GetAll<TEntity>() where TEntity : class;
    }
}
