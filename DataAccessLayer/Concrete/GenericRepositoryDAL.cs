using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepositoryDAL<T> : IRepositoryDAL<T> where T : class
    {
         Context db =new Context(); // sql baglantı

        DbSet<T> _object;//obje  tanımkladık


        //ctor tabtab 
        public GenericRepositoryDAL()   // deger atamak için
        {
            _object=db.Set<T>();

        }

        public void Delete(T t)
        {
            _object.Remove(t);
            db.SaveChanges();
        }

        public void Insert(T t)
        {
           
            _object.Add(t);
            db.SaveChanges();
        }

        public List<T> listDAL()
        {
            return _object.ToList();
        }

        public List<T> list(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        

        public void Update(T t)
        {
            db.SaveChanges();
        }
    }
}
