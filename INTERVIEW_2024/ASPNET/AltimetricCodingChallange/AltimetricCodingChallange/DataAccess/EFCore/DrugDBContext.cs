using AltimerticCodeChallenge.Entities;
using Microsoft.EntityFrameworkCore;


namespace AltimerticCodeChallenge.DataAccess.EFCore
{
    public class DrugDBContext:DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public DrugDBContext(DbContextOptions<DrugDBContext> options) : base(options){}
        
        public DbSet<Drug> Drugs { get; set; }
    }
}
