using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Entity> : IGenericDal<Entity> where Entity : class, IEntity, new()
    {
        public void Delete(Entity entity)
        {
            using var c = new Context();
            c.Entry(entity).State = EntityState.Deleted;
            c.SaveChanges();
        }

        public List<Entity> GetAll()
        {
            using var c = new Context();
            return c.Set<Entity>().ToList();
        }

        public Entity GetById(int id)
        {
            using var c = new Context();
            return c.Set<Entity>().Find(id);
        }

        public void Save(Entity entity)
        {
            using var c = new Context();
            c.Entry(entity).State = EntityState.Added;
            c.SaveChanges();
        }

        public void Update(Entity entity)
        {
            using var c = new Context();
            c.Entry(entity).State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
