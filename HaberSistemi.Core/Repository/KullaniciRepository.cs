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
    public class KullaniciRepository : IKullaniciRepository
    {
        private readonly HaberContext context = new HaberContext();
        public IEnumerable<Kullanici> GetAll()
        {
            return context.Kullanici.Select(x => x);
        }

        public Kullanici GetById(int id)
        {
            return context.Kullanici.FirstOrDefault(x => x.ID == id);
        }
        public Kullanici Get(Expression<Func<Kullanici, bool>> expression)
        {
            return context.Kullanici.FirstOrDefault(expression);
        }

        public IQueryable<Kullanici> GetMany(Expression<Func<Kullanici, bool>> expression)
        {
            return context.Kullanici.Where(expression);
        }

        public void Insert(Kullanici Obj)
        {
            context.Kullanici.Add(Obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Kullanici Obj)
        {
            context.Kullanici.AddOrUpdate(Obj);
        }
        public int Count()
        {
            return context.Kullanici.Count();
        }

        public void Delete(int id)
        {
            var kullanici = GetById(id);
            if (kullanici != null)
            {
                context.Kullanici.Remove(kullanici);

            }

        }
    }
}
