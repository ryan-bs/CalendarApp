using CalendarApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CalendarApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<EventoModel> EventoModels { get; set; }
        public DbSet<UsuarioModel> UsuarioModels { get; set; }
    }
}