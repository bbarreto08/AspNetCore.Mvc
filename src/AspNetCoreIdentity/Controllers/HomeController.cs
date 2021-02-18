using AspNetCoreIdentity.Extensions;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {                        
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Gestor")]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "PodeExecutar")]
        public IActionResult SecretClaim()
        {
            return View();
        }

        [Authorize(Policy = "PodeGravar")]
        public IActionResult SecretClaimGravar()
        {
            return View();
        }

        [ClaimsAuthorize("Produto", "Ler")]
        public IActionResult ClaimsCustom()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            switch (id)
            {
                case 500:
                    modelErro.Mensagem = "Erro interno";
                    modelErro.Titulo = "Ocorreu um erro";
                    modelErro.ErrorCode = id;
                    break;

                case 404:
                    modelErro.Mensagem = "Página não emcontrada";
                    modelErro.Titulo = "Página não emcontrada";
                    modelErro.ErrorCode = id;
                    break;

                case 403:
                    modelErro.Mensagem = "Não possui permissão para esta ação";
                    modelErro.Titulo = "Não autorizado";
                    modelErro.ErrorCode = id;
                    break;

                default:
                    modelErro.Mensagem = "Página não emcontrada";
                    modelErro.Titulo = "Página não emcontrada";
                    modelErro.ErrorCode = id;
                    break;
            }

            return View("Error", modelErro);
        }
    }
}
