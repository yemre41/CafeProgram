using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Abstract
{
    public interface ITatlı
    {
        void AddTatlı(Tatlı tatlı);
        void DeleteTatlı(Tatlı tatlı);
        void UpdateTatlı(Tatlı tatlı);
        Tatlı GetTatlıById(int id);
        List<Tatlı> ListAllTatlı();
    }
}
