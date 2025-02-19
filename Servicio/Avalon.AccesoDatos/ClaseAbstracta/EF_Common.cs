using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.ClaseAbstracta
{
    public abstract class EF_Common : InterfazGenerica.IGenericRepository
    {
        public TEntity Add<TEntity>(TEntity toCreate) where TEntity : class
        {
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    TEntity result = default(TEntity);
                    try
                    {
                        db.Set<TEntity>().Add(toCreate);
                        db.SaveChanges();
                        result = toCreate;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete<TEntity>(TEntity toDelete) where TEntity : class
        {
            bool result = false;
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    db.Entry<TEntity>(toDelete).State = EntityState.Deleted;
                    result = db.SaveChanges() > 0;
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {

        }

        public TEntity Get<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            TEntity result = default(TEntity);
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    result = db.Set<TEntity>().FirstOrDefault(criteria);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TEntity> GetAll<TEntity>() where TEntity : class
        {
            List<TEntity> result = null;
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    result = db.Set<TEntity>().ToList();
                    return result;
                }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TEntity> GetAllByCritearia<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            List<TEntity> result = null;
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    result = db.Set<TEntity>().Where(criteria).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update<TEntity>(TEntity toUpdate) where TEntity : class
        {
            bool result = false;
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    db.Entry<TEntity>(toUpdate).State = EntityState.Modified;
                    result = db.SaveChanges() > 0;
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
