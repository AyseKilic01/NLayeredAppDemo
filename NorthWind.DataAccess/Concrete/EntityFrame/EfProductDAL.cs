using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete
{
   public class EfProductDAL:IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.ToList();
            }
        }
        public void Add(Product products)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                //context.Products.Add(products);
                var entity = context.Entry(products);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product products)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var entity = context.Entry(products);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product products)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var entity = context.Entry(products);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Product> GetUnitePrice(decimal price)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.Where(x => x.UnitPrice >= price).ToList();
            }
        }
        public List<Product> GetUnitePrice(decimal max, decimal min)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.Where(x => x.UnitPrice >= min && x.UnitPrice < max).ToList();
                //where ile direkt tablodan koşul ile veri alabiliyoruz
            }
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
    }
}
