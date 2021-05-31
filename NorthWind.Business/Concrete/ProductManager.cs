using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Concrete
{
   public class ProductManager:IProductService
    {
        private IProductDal _dal;

        public ProductManager(IProductDal productDal)
        {
            _dal = productDal;
        }

        public List<Product> GetAll()
        {
            return _dal.GetAll();
            
        }
    }
}
