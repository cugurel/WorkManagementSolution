using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : IUserDal
    {
        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
