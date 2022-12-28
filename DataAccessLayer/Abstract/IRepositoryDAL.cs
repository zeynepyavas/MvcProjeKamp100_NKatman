using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDAL<T>
    {
        //CRUD 
        //Tpye Name();
        //Generic İnterface işlenidir
        List<T> listDAL();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);

        List<T> list(Expression<Func<T,bool>> filter);

    }
}
