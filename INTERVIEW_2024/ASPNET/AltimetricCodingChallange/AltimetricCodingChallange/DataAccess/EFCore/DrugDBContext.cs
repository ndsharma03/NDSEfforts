using AltimerticCodeChanllenge.Entities;
using Microsoft.EntityFrameworkCore;


namespace AltimerticCodeChanllenge.DataAccess.EFCore
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
