using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IJobDal: IGenericDal<Job> //İlgili interfaceme ait sınıfı çağırdım. Böylece artık Job sınıfı için 4-5 tane methodu yazmama gerek kalamdı.
    {
    }
}
