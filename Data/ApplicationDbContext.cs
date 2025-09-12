using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgendaMedica.Models;

namespace AgendaMedica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AgendaMedica.Models.Especialidade> Especialidade { get; set; } = default!;
        public DbSet<AgendaMedica.Models.Medico> Medico { get; set; } = default!;
        public DbSet<AgendaMedica.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<AgendaMedica.Models.Agenda> Agenda { get; set; } = default!;
    }
}
