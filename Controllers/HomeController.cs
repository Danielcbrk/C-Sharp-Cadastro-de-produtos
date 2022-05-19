using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using atividade_2.Models;

namespace atividade_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            //carregar a view de cadastro
            return View();
        }

        [HttpPost]

        public IActionResult Cadastro(ItemPedido itemForm)
        {
            //receber dados de formulario e salvar (memória)
            Dados.PedidoAtual.AdicionaServico(itemForm);

            return View();

        }

        public IActionResult Listagem()
        {
            List<ItemPedido> listagemDaMem = Dados.PedidoAtual.ListaPedidos();

            return View(listagemDaMem);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
