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
        * 13 Temmuz 2022-14 Dersin özeti 
        * 
        * Controllerda methodlar yazdık bu methodlar geriye deger dönen ve dönmeyen methodlardı (void,int,string) 
        * bunları IActionresult ile viewBag anahtar keywordu ile çağırdık
        * ve bu IActionResult ile yazdıgımız kodun içine giderek yazdıgımız kodları sayfada gösterdik
        * Kullanımı aşağıda ve kodun içine giderek görüntüleyebiliriz 
        * ViewBag method içinde kullanımı 
        * ViewBag.Kullanılandegiskenismi=MethodunIsmi()
        * Index --> Right Click--> Go to view
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
            Cities city1 = new Cities();
            city1.Id = 1;
            city1.Name = "Istanbul";
            city1.Country = "Turkey";
            city1.Population = 2500000;

            ViewBag.id1 = city1.Id;
            ViewBag.name1 = city1.Name;
            ViewBag.country1 = city1.Country;
            ViewBag.population1 = city1.Population;


            return View();

        }
    }
}
