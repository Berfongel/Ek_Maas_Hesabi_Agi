using Microsoft.AspNetCore.Mvc;
using SabitMaasHesabiWebApplication.Models;
using System.Diagnostics;

namespace SabitMaasHesabiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(SabitMaasHesabi sabitMaasHesabi)
        {
            double sabit_maas_=1.500;
            var saatlik_ucret_ = sabitMaasHesabi.Saatlik_Ucret;
            var calisma_saati_ = sabitMaasHesabi.Calisma_Saati;
            var cocuk_sayisi_ = sabitMaasHesabi.Cocuk_Sayisi;
            double maas;
            var message = string.Empty;
            var message1_ = string.Empty;
            if (cocuk_sayisi_ == 1)
            {
                maas = sabit_maas_ + (sabit_maas_ * 5) / 100;
                message = "Ek maaşınız : " + maas;


            }
            else if (cocuk_sayisi_ == 2)
            {
                maas = sabit_maas_ + (sabit_maas_ * 10) / 100;
                message = "Ek maaşınız : " + maas;


            }
            else if (cocuk_sayisi_ == 0)
            {
                message = "Maaşınıza ekleme yapılmayacaktır. Sabit maaşınız : " + sabit_maas_;
            }

            else 
            {
                maas = sabit_maas_ + (sabit_maas_ * 15) / 100;

                message = "Ek maaşınız : " + sabit_maas_;

            }
            ViewBag.Message = message1_;
            ViewBag.Message = message;
            return View("sabitMaasHesabi");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}