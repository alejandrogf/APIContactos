using System.Collections.Generic;

namespace RepositorioAdapter.Adapter
{
    /*1.- Crear carpeta Adapter.
      2.- Crear Interface -> IAdapter. Va a recibir un modelo y viewmodel y los relaciona
    */
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity">Objeto de entidad de la base de datos</typeparam>
    /// <typeparam name="TModel">Objeto de transferencia, es lo que mando al movil, etc</typeparam>
    public interface IAdapter<TEntity, TModel>
    {
        //Para un objeto único
        //De un Model obtiene su viewmodel y viceversa
        //TModel es el extremo de los datos planos y TEntity es el extremo del entity
        TEntity FromViewModel(TModel model);
        TModel FromModel(TEntity model);
        //Para una colección de objetos
        //De un Model obtiene su viewmodel y viceversa
        ICollection<TEntity> FromViewModel(ICollection<TModel> model);
        ICollection<TModel> FroModel(ICollection<TEntity> model);
    }
}