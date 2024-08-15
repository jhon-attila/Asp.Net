using AppQuarta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppQuarta.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastrarPessoa()
        {
            return View();
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPessoa(Pessoa objpessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", objpessoa);
            }
            return View();
        }
        public IActionResult Resultado(Pessoa objpessoa)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto objProduto)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoProduto", objProduto);
            }
            return View();
        }
        public IActionResult ResultadoProduto(Produto objProduto)
        {
            return View();
        }
    
    }
}
