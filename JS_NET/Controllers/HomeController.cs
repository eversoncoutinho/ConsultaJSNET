using JS_NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace JS_NET.Controllers
{
    //tempos

    public class HomeController : Controller
    {
        int x = 0;
        int y = 1;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ObterTelefone(string email)
        {
            var deplay = new Random().Next(x, y) * 1000;
            Thread.Sleep(deplay); //simular a demora do DB
            //esses dados podem estar armazenados em um BD e a consultar ser feita pelo EF
            var result = new { telemovel = "+351934924529", telefoneTrabalho = "+351211123456" }; 
            return Json(result);
        }

        [HttpGet]
        public JsonResult ObterDataNascimento(string telemovel)
        {
            var deplay = new Random().Next(x, y) * 1000;
            Thread.Sleep(deplay);
            var result = new { dataNascimento = "27/09/1981" };
            return Json(result);
        }

        [HttpGet]
        public JsonResult ObterResumo()
        {
            var deplay = new Random().Next(x, y) * 1000;
            Thread.Sleep(deplay);

            //idade
            CultureInfo culture = new CultureInfo("pt-pt");
            DateTime datanascimento = Convert.ToDateTime("27/09/1981", culture);
            DateTime today = DateTime.Now;

//            DateTime datanascimento = new DateTime(datanasciment);
            TimeSpan idadeDays = today.Subtract(datanascimento); // 127.04:15:10
            int idade = (int)(idadeDays.TotalDays)/365;            
            var result = new { telemovel = "+351934924529", telefoneTrabalho = "+351211123456", idade=$"{idade}" };
            
            return Json(result);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
