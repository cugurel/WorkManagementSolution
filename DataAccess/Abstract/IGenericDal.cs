using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<Entity> where Entity : class, IEntity, new()
    {
        void Save(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);
        Entity GetById(int id);
        List<Entity> GetAll();
    }
}
