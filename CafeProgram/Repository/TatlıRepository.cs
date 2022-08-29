using CafeProgram.Abstract;
using CafeProgram.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Repository
{
    public class TatlıRepository : ITatlı
    {
        DbCafe context = new DbCafe();
        public void AddTatlı(Tatlı tatlı)
        {
            context.Add(tatlı);
            context.SaveChanges();
        }

        public void DeleteTatlı(Tatlı tatlı)
        {
            context.Remove(tatlı);
            context.SaveChanges();
        }

        public Tatlı GetTatlıById(int id)
        {
            return context.tatlilar.Find(id);
        }

        public List<Tatlı> ListAllTatlı()
        {
            return context.tatlilar.ToList();
        }

        public void UpdateTatlı(Tatlı tatlı)
        {
            context.Update(tatlı);
            context.SaveChanges();
        }
    }
}
