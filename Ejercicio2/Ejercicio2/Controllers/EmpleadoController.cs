using Ejercicio2.Config;
using Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio2.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadosContext _context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            _context = context;
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<Empleado>>> Get()
        {
            return await _context.Empleados.ToListAsync();
        }

        [HttpPost("save")]
        public async Task<ActionResult> Post(Empleado empleado)
        {
            _context.Add(empleado); //añade al contexto
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
