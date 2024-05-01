using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions;
using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Logging;
namespace PortfolioManager.Models
{
    public class PMDataContext : DbContext
    {
        ILogger logger;
        public PMDataContext()
        {

        }
        public PMDataContext(ILogger _logger)
        {
            logger = _logger;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;
            //SQL SErver 2008:"server=NIRANJANS\\SQLEXPRESS;uid=sa;pwd=sa; database=PortfolioManager"
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
           // logger.Log(LogLevel.Information, "Inside OnConfiguring");
            
        }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioStock> PortfolioStocks { get; set; }
        public DbSet<AssetClass> AssetClasses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<StockBroker> StockBrokers { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<RateHistory> RateHistories { get; set; }
    }
}
