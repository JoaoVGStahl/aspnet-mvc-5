using FirstMVC5.Models;
using System.Data.Entity;

namespace FirstMVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}