using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Service
{
    public interface ITatlıService
    {
        void TatlıAdd(Tatlı tatlı);
        void TatlıDelete(Tatlı tatlı);
        void TatlıUpdate(Tatlı tatlı);
        List<Tatlı> GetList();
        Tatlı GetById(int id);
    }
}
