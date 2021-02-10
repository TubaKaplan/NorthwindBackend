using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Rspository Pattern Disayn :  We use generic repository for access the data
    // T:class => T need to be reference type and need to be inherite from IEntity or itself
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
