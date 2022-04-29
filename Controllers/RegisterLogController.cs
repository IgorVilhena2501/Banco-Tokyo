
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Banco_Toyko.Models.Request.RequestCliente;
using Banco_Toyko.Repository.ClienteRepository;
using Banco_Toyko.Models;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Controllers
{
    public class RegisterLogController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RegisterLogController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public void Autorizar(bool request)
        {
            LogedOrNot.Set(request);
        }

    }
}
