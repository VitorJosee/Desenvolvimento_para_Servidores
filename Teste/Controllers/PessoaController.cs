using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Teste.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPessoas = new List<Pessoa>();
        public IActionResult Index()
        {
            return View(lsPessoas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Pessoa c)
        {
            lsPessoas.Add(c);
            return RedirectToAction("index");
        }
        public IActionResult excluir()
        {
            return View();
        }
    }
}
