using CafeProgram.Manager;
using CafeProgram.Models;
using CafeProgram.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CafeProgram.Models.EntityFramework.DbCafe;

namespace CafeProgram.Controllers
{
    public class CafeController : Controller
    {
        YiyecekManager ym = new YiyecekManager(new YiyecekRepository());
        IcecekManager ım = new IcecekManager(new IcecekRepository());
        TatlıManager tm = new TatlıManager(new TatlıRepository());

        public IActionResult Yiyecek()
        {
            List<Yiyecek> values = ym.GetList();
            UrunSecimi urunSecimi = new()
            {
                Kategori = "Yiyecekler",
                Urunler = values.Select(yiyecek => new Urun
                {
                    UrunId = yiyecek.yiyecekId,
                    UrunIsmi = yiyecek.yiyecekName,
                    SeciliMi = false,
                    UrunFiyat = yiyecek.yiyecekValue
                }).ToList()
            };
            return View(urunSecimi);
        }
        public IActionResult Tatlı()
        {
            List<Tatlı> values = tm.GetList();
            UrunSecimi urunSecimi = new()
            {
                Kategori = "Tatlılar",
                Urunler = values.Select(tatlı => new Urun
                {
                    UrunId = tatlı.tatlıId,
                    UrunIsmi = tatlı.tatlıName,
                    SeciliMi = false,
                    UrunFiyat = tatlı.tatlıValue
                }).ToList()
            };
            return View(urunSecimi);
        }
        public IActionResult Icecek()
        {
            List<Icecek> values = ım.GetList();
            UrunSecimi urunSecimi = new()
            {
                Kategori = "Icecekler",
                Urunler = values.Select(ıcecek => new Urun
                {
                    UrunId = ıcecek.icecekId,
                    UrunIsmi = ıcecek.icecekName,
                    SeciliMi = false,
                    UrunFiyat = ıcecek.icecekValue
                }).ToList()
            };
            return View(urunSecimi);

        }
        public IActionResult UrunSec(UrunSecimi urunSecimi )
        {
            HttpContext.Session.SetString(urunSecimi.Kategori, JsonConvert.SerializeObject(urunSecimi.Urunler));
            switch (urunSecimi.Kategori)
            {
                case "Yiyecekler":
                    return RedirectToAction("Tatlı");
               
                case "Tatlılar":
                    return RedirectToAction("İcecekler");
               
                case "İcecekler":
                    return RedirectToAction("Hesapla");
                
            }
            return BadRequest();
        }

        public void Hesapla()
        {
            foreach (string kategori in HttpContext.Session.Keys)
            {
                List<Urun> urunler = JsonConvert.DeserializeObject<List<Urun>>(HttpContext.Session.GetString(kategori));
            }
            
        }



    }
}