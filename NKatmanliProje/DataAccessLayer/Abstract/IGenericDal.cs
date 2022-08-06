using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // T burda bir entity , T entity sinden bir t parametresi uretiyoruz.
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        //get all
        List<T> GetAll();
        //get one
        T GetById(int id);
    }
}
