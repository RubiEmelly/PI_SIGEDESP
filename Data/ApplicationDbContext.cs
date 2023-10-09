using Microsoft.EntityFrameworkCore;
using SIGEDESP_PI.Models;

namespace SIGEDESP_PI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public DbSet<InstituicaoModel> Instituicao { get; set; }
    }
}
