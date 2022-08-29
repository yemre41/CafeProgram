using CafeProgram.Abstract;
using CafeProgram.Models.EntityFramework;
using CafeProgram.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Manager
{
    public class TatlıManager : ITatlıService
    {
        ITatlı tatlı1;
        public TatlıManager(ITatlı tatlı)
        {
            tatlı1 = tatlı;
        }
        public Tatlı GetById(int id)
        {
            return tatlı1.GetTatlıById(id);
        }

        public List<Tatlı> GetList()
        {
            return tatlı1.ListAllTatlı();
        }

        public void TatlıAdd(Tatlı tatlı)
        {
            tatlı1.AddTatlı(tatlı);
        }

        public void TatlıDelete(Tatlı tatlı)
        {
            tatlı1.DeleteTatlı(tatlı);
        }

        public void TatlıUpdate(Tatlı tatlı)
        {
            tatlı1.UpdateTatlı(tatlı);
        }
    }
}
