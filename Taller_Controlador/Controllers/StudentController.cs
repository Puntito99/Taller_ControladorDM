using Microsoft.AspNetCore.Mvc;

namespace Taller_Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Controlador de estudiantes";
        }
    }
}
