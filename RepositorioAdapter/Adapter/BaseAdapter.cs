using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioAdapter.Adapter
{
    abstract class BaseAdapter<TEntity, TModel>:IAdapter<TEntity,TModel>
    {
        public abstract TEntity FromViewModel(TModel model);


        public abstract TModel FromModel(TEntity model);

        /*Estos dos están implementados ya que sabemos parte de las instrucciones a realizar
        Al ser una colección, hay que recorrerla y obtener el elemento correspondiente cada vez*/
        public   ICollection<TEntity> FromViewModel(ICollection<TModel> model)
        {
            return model.Select(FromViewModel).ToList();
            /*Versión Larga:
            var retorno=new List<TModel>();
            foreach (var entity in model)
            {
                retorno.Add(FromModel(entity));
            }
            return retorno;
            
            */
        }

        public  ICollection<TModel> FroModel(ICollection<TEntity> model)
        {
            return model.Select(FromModel).ToList();
        }
    }
}
