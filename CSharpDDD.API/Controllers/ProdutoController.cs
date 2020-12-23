using Microsoft.AspNetCore.Mvc;

namespace CSharpDDD.API.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
