using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Abstract
{
    public interface IIcecek
    {
        void AddIcecek(Icecek ıcecek);
        void DeleteIcecek(Icecek ıcecek);
        void UpdateIcecek(Icecek ıcecek);
        Icecek GetIcecekById(int id);
        List<Icecek> ListAllIcecek();
    }
}
