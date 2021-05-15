using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete.NHibernate
{
    class NhProductDAL : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
