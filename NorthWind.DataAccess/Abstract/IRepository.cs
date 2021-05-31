using NorthWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T GetByID(int id);
        void Add(T p);
        void Update(T p);
        void Delete(T p);
    }
}
