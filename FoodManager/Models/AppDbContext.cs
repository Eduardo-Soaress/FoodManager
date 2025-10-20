using Microsoft.EntityFrameworkCore;

namespace FoodManager.Models
{
    //Classe responsável por fazer a configuração do Entity Framework
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //Toda nova entidade que for criada, deve ser adicionada aqui

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
