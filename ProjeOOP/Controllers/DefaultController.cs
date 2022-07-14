using Microsoft.AspNetCore.Mvc;
using ProjeOOP.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOOP.Controllers
{
    public class DefaultController : Controller
    {

        /*
         * 13 Temmuz 2022-Chapter 14 Günün özeti 
         * 
         * Controllerda methodlar yazdık bu methodlar geriye deger dönen ve dönmeyen methodlardı (void,int,string) 
         * bunları IActionresult ile viewBag anahtar keywordu ile çağırdık
         * ve bu IActionResult ile yazdıgımız kodun içine giderek yazdıgımız kodları sayfada gösterdik
         * Kullanımı aşağıda ve kodun içine giderek görüntüleyebiliriz 
         * ViewBag method içinde kullanımı 
         * ViewBag.Kullanılandegiskenismi=MethodunIsmi()
         * Index --> Right Click--> Go to view
         * 
         * 14 Temmuz 2022-Günün özeti
         * Yeni bir sınıf eklendi(Flag)
         * City sınıfına yeni bir property eklendi(CountYear)
         * Bootstrap ile tasarım iyileşti city sayfasında 
         * Kalıtım öğrenildi. Kalıtım bir sınıfın özelliklerini diğer bir sınıfta  erişebilmesi
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
         */

        void Messages()
        {
            ViewBag.m1 = "Say hi this is a core project";
            ViewBag.m2 = "Hi Berkay";
            ViewBag.m3 = "Hi Man";
        }
        
        int Sum()
        {
            int number1 = 20;
            int number2 = 30;
            int result = number1 + number2;
            return result;
        }
        int Circumference()
        {
            int shorter = 5;
            int tall = 3;
            int result = 2 * (shorter + tall);
            return result;
        }
        string Word(string who)
        {
            string word1 = $"He is a name  {who}.He is a  cool boy.";
            return word1;
        }
        void MessageList(string message)
        {
            ViewBag.message = message;
        }
       
        void Users(string username)
        {
            ViewBag.username = username;
            
        }
        int Sum2(int number1,int number2)
        {
            int result = number1 + number2;
            return result;
        }
        int Factorial(int number)
        {
            int defaultNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                defaultNumber = defaultNumber * i;
            }
            return defaultNumber;
        }

        public IActionResult Index()
        {
            Messages();
            MessageList("This is a message alarms");
            Users("Berkayakkocc");
            ViewBag.sum1= Sum2(3, 8);
            ViewBag.factorial1 = Factorial(7);
            return View();
        }

        public IActionResult Products()
        {
            Messages();
            ViewBag.s = Sum();
            ViewBag.circum = Circumference();
            Users("Berkayakkocc2");
            ViewBag.sum2= Sum2(6, 9);
            ViewBag.factorial2 = Factorial(3);
            return View();
        }
        public IActionResult Customer()
        {
            ViewBag.word = Word("Berkay");
            Users("AdminBerkay");
            ViewBag.sum3= Sum2(2, 8);
            ViewBag.factorial3 = Factorial(8);
            return View();
        }
        public IActionResult City()
        {
            Cities city = new Cities();
            city.Id = 1;
            city.Name = "Istanbul";
            city.Country = "Turkey";
            city.Population = 15636000;
            city.CountYear = 2022;
            city.Color1 = "Red";
            city.Color2 = "White";


            ViewBag.id1 = city.Id;
            ViewBag.name1 = city.Name;
            ViewBag.country1 = city.Country;
            ViewBag.population1 = city.Population;
            ViewBag.countYear1 = city.CountYear;
            ViewBag.color1 = city.Color1;
            ViewBag.color2 = city.Color2;
            ViewBag.color3 = city.Color3;

            city.Id = 2;
            city.Name = "Skopje";
            city.Country = "Macedonia";
            city.Population = 606000;
            city.CountYear = 2022;
            city.Color1 = "Yellow";
            city.Color2 = "Red";


            ViewBag.id2 = city.Id;
            ViewBag.name2 = city.Name;
            ViewBag.country2 = city.Country;
            ViewBag.population2 = city.Population;
            ViewBag.countYear2 = city.CountYear;
            
            ViewBag.color1_2 = city.Color1;
            ViewBag.color2_2 = city.Color2;
            ViewBag.color3_2 = city.Color3;




            return View();

        }
    }
}
