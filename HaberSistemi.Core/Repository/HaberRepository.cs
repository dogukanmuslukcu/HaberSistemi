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
    public class HaberRepository : IHaberRepository
    {
       
        private readonly HaberContext context = new HaberContext();

        public IEnumerable<Haber> GetAll()
        {
            return context.Haber.Select(x => x); 
        }
        public Haber GetById(int id)
        {
            return  context.Haber.FirstOrDefault( x=> x.ID == id);
        }


        public Haber Get(Expression<Func<Haber, bool>> expression)
        {
            return context.Haber.FirstOrDefault(expression);
        }


        public IQueryable<Haber> GetMany(Expression<Func<Haber, bool>> expression)
        {
            return context.Haber.Where(expression);

        }

        public void Insert(Haber Obj)
        {
           context.Haber.Add(Obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Haber Obj)
        {
           context.Haber.AddOrUpdate(Obj);
        }
        public int Count()
        {
            return context.Haber.Count();
        }

        public void Delete(int id)
        {
             var haber = GetById(id);
            if (haber != null) 
            {
                context.Haber.Remove(haber);
            
            }
        }

       
    }
}
