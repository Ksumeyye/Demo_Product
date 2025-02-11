using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfJobDal:GenericRepository<Job>, IJobDal //GenericRepository içinde bir entity bekliyor bunun için <Job> yazdım. IJobDal'dan ve GenericRepositoryden miras aldım.
    {
    }
}
