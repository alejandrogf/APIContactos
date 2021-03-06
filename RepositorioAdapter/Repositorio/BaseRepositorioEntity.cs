﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RepositorioAdapter.Adapter;

namespace RepositorioAdapter.Repositorio
{
    public class BaseRepositorioEntity<TEntity, TModel, TAdapter> : IRepositorio<TEntity, TModel, TAdapter>
        where TAdapter : IAdapter<TEntity, TModel>, new()//Que el adapter no sea abstracta, que tenga constructor
        where TEntity : class
        where TModel : class 
    {
        public TModel Add(TModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(Expression<Func<TModel, bool>> consulta)
        {
            throw new NotImplementedException();
        }

        public int Delete(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public int Update(TModel model)
        {
            throw new NotImplementedException();
        }

        public TModel Get(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public ICollection<TModel> Get(Expression<Func<TModel, bool>> consulta)
        {
            throw new NotImplementedException();
        }

        public ICollection<TModel> Get()
        {
            throw new NotImplementedException();
        }
    }
}
