using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoTravelCan.Models
{
    public class Contexto : IdentityDbContext
    {
        public DbSet<Perro> Perros {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Viaje> Viajes {get;set;}
        public DbSet<ReservaViaje> Reservas {get;set;}

        public Contexto(DbContextOptions<Contexto> o) : base(o){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<ReservaViaje>().HasKey(p => new { p.IdCliente, p.IdViaje });

            base.OnModelCreating(modelBuilder);
        }
    }
}