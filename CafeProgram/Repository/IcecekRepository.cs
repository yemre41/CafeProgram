using CafeProgram.Abstract;
using CafeProgram.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Repository
{
    public class IcecekRepository : IIcecek
    {
        DbCafe context = new DbCafe();
        public void AddIcecek(Icecek ıcecek)
        {
            context.Add(ıcecek);
            context.SaveChanges();
        }

        public void DeleteIcecek(Icecek ıcecek)
        {
            context.Remove(ıcecek);
            context.SaveChanges();
        }

        public Icecek GetIcecekById(int id)
        {
            return context.icecekler.Find(id);
        }

        public List<Icecek> ListAllIcecek()
        {
            return context.icecekler.ToList();
        }

        public void UpdateIcecek(Icecek ıcecek)
        {
            context.Update(ıcecek);
            context.SaveChanges();
        }
    }
}
