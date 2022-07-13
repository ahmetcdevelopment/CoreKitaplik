using System;
using System.Collections.Generic;
using CoreKitaplik.Models;
using Microsoft.AspNetCore.Mvc;
namespace CoreKitaplik.ViewComponents
{
    public class YeniKitaplar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitapListesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    Id=6,
                    KitapAd="Korku",
                    Yazar="Zweig",
                },
                new Kitaplar
                {
                    Id=7,
                    KitapAd="Anna Karenina",
                    Yazar="Tolstoy",
                }
            };
            return View(kitapListesi);
        }
        
    }
}
