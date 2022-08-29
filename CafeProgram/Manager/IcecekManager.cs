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
    public class IcecekManager : IIcecekService
    {
        IIcecek ıcecek1;
        public IcecekManager(IIcecek ıcecek)
        {
            ıcecek1 = ıcecek;
        }
        public Icecek GetById(int id)
        {
            return ıcecek1.GetIcecekById(id);

        }

        public List<Icecek> GetList()
        {
            return ıcecek1.ListAllIcecek();
        }

        public void IcecekDelete(Icecek ıcecek)
        {
            ıcecek1.DeleteIcecek(ıcecek);  
        }

        public void IcecekkAdd(Icecek ıcecek)
        {
            ıcecek1.AddIcecek(ıcecek);
        }

        public void IcecekUpdate(Icecek ıcecek)
        {
            ıcecek1.UpdateIcecek(ıcecek);
        }
    }
}
