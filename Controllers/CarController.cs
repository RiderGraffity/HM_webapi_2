using Microsoft.AspNetCore.Mvc;

namespace HM_webapi_2.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private List<ModelsOfCars> Cars = new List<ModelsOfCars>
        {
            new ModelsOfCars("BMW", "M5", 12000000),
            new ModelsOfCars("Mercedes", "E-Class", 8000000),
            new ModelsOfCars("Audi", "RS7", 10000000),
            new ModelsOfCars("Porsche", "911", 15000000)
        };

        [HttpGet("getAll")]
        public IActionResult GetAllCars()
        {
            return View(Cars);
        }
    }
}