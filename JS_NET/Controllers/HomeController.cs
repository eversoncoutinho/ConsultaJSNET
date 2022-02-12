using JS_NET.Data;
using JS_NET.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace JS_NET.Controllers
{


    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ObterTelefone(string email)
        {
            if (email == null)
            {
                return NotFound();
            }
            var telefone = (from c in _context.Clientes
                            where c.email == email
                            select c);

            if (telefone != null)
            {

                foreach (var c in telefone)
                {
                    var result = new { telefoneTrabalho = c.telefone, telemovel = c.telemovel };
                    return new JsonResult(result);
                }
            }
                return NotFound();
            }

        

        [HttpGet]
        public IActionResult ObterDataNascimento(int telemovel)
        {
            //var deplay = new Random().Next(x, y) * 1000;
            //Thread.Sleep(deplay);
            if (telemovel == 0)
            {
                return NotFound();
            }
            var telemovelQ = (from c in _context.Clientes
                              where c.telemovel == telemovel
                              select c);

            if (telemovelQ != null)
            {

                foreach (var c in telemovelQ)
                {
                    var nascimento = String.Format(" {0:dd/MMM/yyyy}",c.nascimento);
                    var result = new { dataNascimento = nascimento};
                    return new JsonResult(result);
                }
            }
            return NotFound();
        }


        [HttpGet]
        public IActionResult ObterResumo(string email)
        {
            //var deplay = new Random().Next(x, y) * 1000;
            //Thread.Sleep(deplay);
            if (email == null)
            {
                return NotFound();
            }
            var resumoQ = (from c in _context.Clientes
                           where c.email == email
                           select c);

            if (resumoQ != null)
            {
                foreach (var c in resumoQ)
                {
                    CultureInfo culture = new CultureInfo("pt-pt");
                    DateTime datanascimento = Convert.ToDateTime(c.nascimento, culture);
                    DateTime today = DateTime.Now;
                    TimeSpan idadeDays = today.Subtract(datanascimento); // 127.04:15:10
                    int idade = (int)(idadeDays.TotalDays) / 365;
                    var result = new { telemovel = c.telemovel, telefoneTrabalho = c.telefone, idade = $"{idade}" };
                    return new JsonResult(result);
                }
            }
            return NotFound();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
