using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IJobDal
    {
        void Save(Job job);
        void Delete(Job job);
        void Update(Job job);
        Job GetById(int id);
        List<Job> GetAll();

    }
}
