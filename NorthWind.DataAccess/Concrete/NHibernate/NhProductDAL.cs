using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete.NHibernate
{
    class NhProductDAL : IProductDal
    {
        public void Add(Product p)
        {
           
        }

        public void Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.FirstOrDefault(x => x.ProductId == id);
                // return context.Products.SingleOrDefault(x => x.ID == id);
                //tabloda eğer gönderilen id varsa veri çek yoksa default null gönder firstordefault
                //tabloda eğer gönderilen id birden fazla ise sadece bir veriyi çek yoksa default null gönder singleordefault
            }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
