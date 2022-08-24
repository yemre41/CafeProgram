using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Abstract
{
    public interface IYiyecek
    {
        void AddYiyecek(Yiyecek yiyecek);
        void DeleteYiyecek(Yiyecek yiyecek);
        void UpdateYiyecek(Yiyecek yiyecek);
        Yiyecek GetYiyecekById(int id);
        List<Yiyecek> ListAllYiyecek();
    }
}
