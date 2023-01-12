using Ejercicio2.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio2.Config
{
    public class DBEmpleadosContext : DbContext
    {
        public DBEmpleadosContext(DbContextOptions<DBEmpleadosContext> options) : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
