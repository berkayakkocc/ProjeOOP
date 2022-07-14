using Microsoft.AspNetCore.Mvc;
using ProjeOOP.Entity;
using ProjeOOP.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOOP.Controllers
{
    /*
     * * Kalıtım öğrenildi. Kalıtım bir sınıfın özelliklerini diğer bir sınıfta  erişebilmesi
         * Navigation Bar eklendi
         * RenderBody:Diğer sayfalardan gelecek olan içeriği sayfaya yerleştirmek için kullanılır
         * olmadan navigationbar eklenmez.
         * Layout : Sabit Alanlar(Youtube Search)....
         * ProductControllerın içinde foreach ile dbdeki ürünleri listeleyip UI yansıttık.
         * NavBardaki isimlendirmeleri duzenledik
         * Ürün Ekleme işlemini kod aracılığı ile yaptık.
         * Post :Sayfada bir butona basılınca çalışan metot ve attiribute
         * Get : Sayfa yüklenince çalışan metot ve attiribute 
         * MethodOverloading:Bir metotun aynı isimde birden fazla görevi olması
         * Ürünün güncellenmesine ait bilgiler sayfasını getirdim 
            Buton ayarları yapıldı
            Guncellleme butonuna tıklanıldıgında urun bilgileri gelmekte
     * 
     */
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            context.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value=context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            var value= context.Products.Where(x => x.ProductId == product.ProductId).FirstOrDefault();
            value.ProductName = product.ProductName;
            value.Price = product.Price;
            value.Stock = product.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
