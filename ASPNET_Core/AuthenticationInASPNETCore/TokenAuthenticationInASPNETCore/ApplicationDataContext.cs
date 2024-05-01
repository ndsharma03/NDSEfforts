using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace Model
{
  public  class ApplicationDataContext:IdentityDbContext
    {
        private readonly IConfiguration configuration;

        public ApplicationDataContext(DbContextOptions options, IConfiguration configuration  ):base(options)
        {
           this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;"
            //@"Server=(localdb)\mssqllocaldb;Database=WebAPIAuthentication;Trusted_Connection=True;"

            //either here or Startup.cs
           // optionsBuilder.UseSqlServer(configuration["ConnectionStrings:ConnectionString"]);


            base.OnConfiguring(optionsBuilder);
            //this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
      public  DbSet<Employee> Employees { get; set; }
       
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

    }
   
}
