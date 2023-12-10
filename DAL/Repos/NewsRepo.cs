using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepo : Repo, IRepo<News, int, bool>
    {
        public bool Create(News obj)
        {
            db.Newses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Newses.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<News> Get()
        {
            return db.Newses.ToList();
        }

        public News Get(int id)
        {
            return db.Newses.Find(id);
        }

        public bool Update(News obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
