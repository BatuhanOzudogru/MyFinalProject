using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint T yi kısıtlamak
    //class : referans tip olabilir demek
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olablir
    //new() : new'lenebilir olmalı, çünkü IEntityi newlenemez (interface oldugu için)
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
