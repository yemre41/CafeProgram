using CafeProgram.Abstract;
using CafeProgram.Models.EntityFramework;
using CafeProgram.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;
using CafeProgram.Repository;

namespace CafeProgram.Manager
{
    public class YiyecekManager : IYiyecekService
    {
        IYiyecek yiyecek1;
        public YiyecekManager(IYiyecek yiyecek)
        {
            yiyecek1 = yiyecek;
        }
        public Yiyecek GetById(int id)
        {
            return yiyecek1.GetYiyecekById(id);
           
        }

        public List<Yiyecek> GetList()
        {
            return yiyecek1.ListAllYiyecek();

        }

        public void YiyecekAdd(Yiyecek yiyecek)
        {
            yiyecek1.AddYiyecek(yiyecek);
        }

        public void YiyecekDelete(Yiyecek yiyecek)
        {
            yiyecek1.DeleteYiyecek(yiyecek);
        }

        public void YiyecekUpdate(Yiyecek yiyecek)
        {
            yiyecek1.UpdateYiyecek(yiyecek);

        }
    }
}
