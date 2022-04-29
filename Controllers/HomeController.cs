
using Banco_Toyko.Models.Request.RequestCliente;
using Banco_Toyko.Repository.ClienteRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Banco_Toyko.Models;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult VerificarAutorizacao(IActionResult result)
        {
            var retorno = LogedOrNot.Get();
            
            if(retorno == false)
            {
                return View("Login");
            }
            else
            {
                return result;
            }
        }
        public void Autorizar(bool request)
        {
            LogedOrNot.Set(request);
        }

        public IActionResult Index()
        {
            return Login();
        }

        public IActionResult Home()
        {
            return VerificarAutorizacao(View("Home"));
        }
        public IActionResult Transferir()
        {
            return VerificarAutorizacao(View("Transferir"));
        }
        public IActionResult Depositar()
        {
            return VerificarAutorizacao(View("Depositar"));
        }
        public IActionResult Sacar()
        {
            return VerificarAutorizacao(View("Sacar"));
        }
        public IActionResult Historico()
        {
            return VerificarAutorizacao(View("Historico"));
        }
        public IActionResult Contatos()
        {
            return VerificarAutorizacao(View("Contatos"));
        }
        public IActionResult Procurar()
        {
            return VerificarAutorizacao(View("Procurar"));
        }

        public IActionResult LogOut()
        {
            Autorizar(false);

            return View("Login");
        }


        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public IActionResult Register(RequestCreateCliente request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FalidRegister");
            }

            var repository = new ClienteRepository();

            var rand = new Random();
            request.Identificador = rand.Next(100000, 999999);

            var response = repository.CreateCliente(request);

            if (response.Sucesso == false)
            {
                return RedirectToAction("FailedRegister");
            }

            var requestSet = new Cliente()
            {
                Identificador = request.Identificador,
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                CPF = request.CPF,
                Idade = request.Idade,
                Senha = request.Senha
            };


            ClienteLoged.Set(requestSet);
            Autorizar(true);

            return Home();
        }

        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(RequestLoginCliente request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var repository = new ClienteRepository();
            var verificacao = repository.LogCliente(request);
            var requestSearch = new RequestSearchClienteBySenha(request.Senha);


            if (verificacao == false)
            {
                return RedirectToAction("FaliedLogin");
            }

            var cliente = repository.SearchClienteBySenha(requestSearch);

            ClienteLoged.Set(cliente.Obj);
            Autorizar(true);

            return View("Home");
        }



    }
}