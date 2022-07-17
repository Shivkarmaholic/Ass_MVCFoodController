using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Ass_MVCFoodController.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Create(IFormCollection form,ICollection<string> chksouth, ICollection<string> chknorth)
        {
            ViewBag.Name = form["txtname"];
            ViewBag.Mobile = form["txtmobile"];
            ViewBag.South= chksouth;
            ViewBag.North= chknorth;

            return View("Details");
        }
        public IActionResult Details()
        {

            return View();
        }
    }
}
