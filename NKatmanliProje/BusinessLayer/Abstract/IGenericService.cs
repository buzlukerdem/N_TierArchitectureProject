using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // controllerin yapilacagi sinif. Validate icerir.
    // generic isen T alman gerek.
    public interface IGenericService<T>
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        //get all
        List<T> TGetAll();
        //get one
        T TGetById(int id);
    }
}
