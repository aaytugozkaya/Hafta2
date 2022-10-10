using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta2.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult OgrEkle()
        {
            return View();
        }
        public IActionResult OgrList()
        {
            return View();
        }
        [HttpPost]
        public string OgrKaydet(string ogrAd, string ogrSoyad, string ogrNo)
        {
            string message=ogrAd + " " + ogrSoyad + " " + ogrNo + " kaydedildi." ;
            return message;
        }
    }
}
