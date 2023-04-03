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
    public class ResimRepository : IResimRepository
    {
        private readonly HaberContext context = new HaberContext();

       

        public IEnumerable<Resim> GetAll()
        {
            return context.Resim.Select(x => x);
        }

        public Resim GetById(int id)
        {
            return context.Resim.FirstOrDefault(x => x.ID == id);
        }
        public Resim Get(Expression<Func<Resim, bool>> expression)
        {
            return context.Resim.FirstOrDefault(expression);
        }

        public IQueryable<Resim> GetMany(Expression<Func<Resim, bool>> expression)
        {
            return context.Resim.Where(expression);
        }

        public void Insert(Resim Obj)
        {
            context.Resim.Add(Obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Resim Obj)
        {
            context.Resim.AddOrUpdate(Obj);
        }
        public int Count()
        {
            return context.Resim.Count();
        }

        public void Delete(int id)
        {
            var resim = GetById(id);
            if (resim != null)
            {
                context.Resim.Remove(resim);

            }
        }
    }
}
