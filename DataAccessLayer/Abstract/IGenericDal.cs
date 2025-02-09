using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class //T değeri entitydir. Bu T bir classa dair özellikler üzerine almalı.
    {
        void Insert(T t); //T isimli entityden üreyen bir t parametresi.
        void Delete(T t);
        void Update(T t);
        List<T> GetList();

        T GetById(int id); // Id'ye göre T değerini getir.
    }
}
