using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobManager : IGenericService<Job>
    {
        public void Delete(Job entity)
        {
            throw new NotImplementedException();
        }
        -
        public List<Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Job entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Job entity)
        {
            throw new NotImplementedException();
        }
    }
}
