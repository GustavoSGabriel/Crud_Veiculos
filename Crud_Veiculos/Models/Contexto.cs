using Microsoft.EntityFrameworkCore;
using Crud_Veiculos.Models;

namespace Crud_Veiculos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }
        public DbSet<Veiculos> Veiculos { get; set; }
        public DbSet<Crud_Veiculos.Models.Cliente>? Cliente { get; set; }
    }
}
