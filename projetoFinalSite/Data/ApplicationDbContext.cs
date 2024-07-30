using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using projetoFinalSite.Models;

namespace projetoFinalSite.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<AnimalModel> Animal { get; set; }


        public DbSet<ParceiroModel> Parceiro { get; set; }



    }
}
