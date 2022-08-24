using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Service
{
    public interface IYiyecekService 
    {
        void YiyecekAdd(Yiyecek yiyecek);
        void YiyecekDelete(Yiyecek yiyecek);
        void YiyecekUpdate(Yiyecek yiyecek);
        List<Yiyecek> GetList();
        Yiyecek GetById(int id);
    }
}
