using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositorioAdapter.Repositorio
{
    /*
    Tiene que saber qué es cada cosa, por eso se le pasan los tres elementos
    */
    public interface IRepositorio<TEntity,TModel,TAdapter>
    {
        TModel Add(TModel model);

        int Delete(TModel model);//Borrar por el objeto
        int Delete(Expression<Func<TModel, bool>> consulta);//Borrado por expresión
        int Delete(params object[] keys);//Borrado por clave primarias

        int Update(TModel model);

        TModel Get(params object[] keys);
        ICollection<TModel> Get(Expression<Func<TModel, bool>> consulta);
        ICollection<TModel> Get();
    }
}