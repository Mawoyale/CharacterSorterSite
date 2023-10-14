using Microsoft.AspNetCore.Mvc;

namespace CharacterSorterSite.Controllers
{
    public class CentralPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
