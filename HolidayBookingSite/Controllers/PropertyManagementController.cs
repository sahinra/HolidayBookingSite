using Microsoft.AspNetCore.Mvc;

namespace HolidayBookingSite.Controllers
{
    public class PropertyManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
