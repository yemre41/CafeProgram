using CafeProgram.Abstract;
using CafeProgram.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Repository
{
    public class YiyecekRepository : IYiyecek
    {
        DbCafe context = new DbCafe();

        public void AddYiyecek(Yiyecek yiyecek)
        {
            context.Add(yiyecek);
            context.SaveChanges();
        }

        public void DeleteYiyecek(Yiyecek yiyecek)
        {
            context.Remove(yiyecek);
            context.SaveChanges();
        }    

        public Yiyecek GetYiyecekById(int id)
        {
            return context.yiyecekler.Find(id);
        }

        public List<Yiyecek> ListAllYiyecek()
        {
            return context.yiyecekler.ToList();
        }

        public void UpdateYiyecek(Yiyecek yiyecek)
        {
            context.Update(yiyecek);
            context.SaveChanges();
        }

     

      
        
    }
}
