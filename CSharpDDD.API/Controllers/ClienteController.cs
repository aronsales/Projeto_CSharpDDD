using CSharpDDD.Application;
using CSharpDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDDD.API.Controllers
{
    [Route("cliente/")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente ApplicationServiceCliente)
        {
            _applicationServiceCliente = ApplicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
