using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfJobRepository : EfGenericRepository<Job>, IJobDal
    {
        
        
    }
}