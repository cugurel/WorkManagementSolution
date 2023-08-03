using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal
    {
        void Save(User user);
        void Delete(User user);
        void Update(User user);
        Job GetById(int id);
        List<Job> GetAll();
    }
}
