using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract //BusinessLayer benim kontrollerimi yapacağım kısım olacak
{
    public interface IGenericService<T> //Generic olduğu için dışarıdan T entitysi alacak.
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t); // T entitysinden t parametresi ürettim.
        List<T> TGetList();
        T TGetById(int id);
    }
}
