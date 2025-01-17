﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemo.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(string id, Guid categoria)
        {
            var filme = new Filme
            {
                Titulo = "Star Wars",
                DataLancamento = DateTime.Now,
                Genero = "Ficção",
                Avaliacao = 5,
                Valor = 115,
            };

            //return RedirectToAction("Privacy", filme);
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
        // Retornar um Json
            //return Json("{'nome':'Eduardo'}");
        // Retornar um arquivo para download
            //var fileBytes = System.IO.File.ReadAllBytes(@"F:\arquivo.txt");
            //var fileName = "ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        // Retornar uma View
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
