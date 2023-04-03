using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.DataContext;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Core.Repository
{
    public class RolRepository : IRolRepository
    {
        private readonly HaberContext context = new HaberContext();

        public IEnumerable<Rol> GetAll()
        {
            return context.Rol.Select(x => x);
        }

        public Rol GetById(int id)
        {
            return context.Rol.FirstOrDefault(x => x.ID == id);
        }


        public Rol Get(Expression<Func<Rol, bool>> expression)
        {
            return context.Rol.FirstOrDefault(expression);
        }

        public IQueryable<Rol> GetMany(Expression<Func<Rol, bool>> expression)
        {
            return context.Rol.Where(expression);
        }

        public void Insert(Rol Obj)
        {
            context.Rol.Add(Obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Rol Obj)
        {
            context.Rol.AddOrUpdate(Obj);
        }
        public int Count()
        {
            return context.Rol.Count();
        }

        public void Delete(int id)
        {
            var rol = GetById(id);
            if (rol != null)
            {
                context.Rol.Remove(rol);

            }
        }
    }
}
