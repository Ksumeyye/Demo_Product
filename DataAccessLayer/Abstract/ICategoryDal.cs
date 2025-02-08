using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category> //İlgili interfaceme ait sınıfı çağırdım. Böylece artık category sınıfı için 4-5 tane methodu yazmama gerek kalamdı.
    {

    }
}
