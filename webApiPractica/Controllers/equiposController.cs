using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace webApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;

        public equiposController(equiposContext equiposContexto)
        {
            _equiposContext = equiposContexto;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<equipos> ListadoEquipo = (from e in _equiposContext.Equipos select e).ToList();

            if (ListadoEquipo.Count == 0)
                return NotFound();
            return Ok(ListadoEquipo);
        }
    }
}
