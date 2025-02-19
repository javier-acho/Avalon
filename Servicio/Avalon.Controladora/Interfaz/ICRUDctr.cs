using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Interfaz
{
    public interface ICRUDctr<TEntity>
    {
        TEntity Agregar(TEntity modelo);
        TEntity Modificar(TEntity modelo);
        List<TEntity> ListarTodo();
        TEntity ConsultaUno(int id);
        TEntity ConsultaUnoCriterio(Expression<Func<TEntity, bool>> criteria);
        List<TEntity> ConsultarByCriterio(Expression<Func<TEntity, bool>> criteria);
        bool Eliminar(TEntity modelo);
        
    }
}
