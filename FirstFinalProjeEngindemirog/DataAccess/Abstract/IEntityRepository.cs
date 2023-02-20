using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic Constraint
    //Class Referans Tip
    //IEntity: IEntity olabilir veya IEntity implamente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T>where T : class,IEntity,new()
    {
        
        //Filtrede vermeye bilirsin
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //Expression<Func<T,bool>> filter=null yazınca  diğerine ihtiyacımız yok 00 List<T> GetByCategory(int categoryId);
    }
}
