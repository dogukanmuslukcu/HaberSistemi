using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.DataContext;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Core.Repository
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly HaberContext _context = new HaberContext();
        public IEnumerable<Kategori> GetAll()
        {
            return _context.Kategori.Select(x => x);
        }

        public Kategori Get(Expression<Func<Kategori, bool>> expression)
        {
            return _context.Kategori.FirstOrDefault(expression);
        }


        public IQueryable<Kategori> GetMany(Expression<Func<Kategori, bool>> expression)
        {
            return _context.Kategori.Where(expression);

        }

        public void Insert(Kategori Obj)
        {
            _context.Kategori.Add(Obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Kategori Obj)
        {
           _context.Kategori.AddOrUpdate(Obj);
        }
        public int Count()
        {
            return  _context.Kategori.Count();
        }

        public void Delete(int id)
        {
            var Kategori = GetById(id);
            if (Kategori != null)
            {
                _context.Kategori.Remove(Kategori);

            }
        }

        public Kategori GetById(int id)
        {
            return _context.Kategori.FirstOrDefault(x => x.ID == id);
        }
    }
}
