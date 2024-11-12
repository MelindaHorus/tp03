using Microsoft.EntityFrameworkCore;

namespace tp03.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext()
        {
        }

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
