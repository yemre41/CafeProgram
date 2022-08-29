using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Service
{
    public interface IIcecekService
    {
        void IcecekkAdd(Icecek ıcecek);
        void IcecekDelete(Icecek ıcecek);
        void IcecekUpdate(Icecek ıcecek);
        List<Icecek> GetList();
        Icecek GetById(int id);
    }
}
