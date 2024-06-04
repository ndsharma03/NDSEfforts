using AltimerticCodeChanllenge.DataAccess.Dapper;
using AltimerticCodeChanllenge.DTO;
using AltimerticCodeChanllenge.Entities;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AltimerticCodeChanllenge.DataAccess
{
    public class DrugReposiotry : IDrugRepository
    {
        private readonly DapperDrugContext context;
        private readonly ILogger<DapperDrugContext> logger;

        public DrugReposiotry(DapperDrugContext context,ILogger<DapperDrugContext> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public async Task<Drug> Add(DrugDTO drug)
        {
            
            logger.LogInformation("Enter: DrugReposiotry.Add");

            var query = "INSERT INTO DRUGS (Name, DrugCode, IsQualified, ManufactureDate) VALUES (@Name, @DrugCode, @IsQualified, @ManufactureDate)"+
                         "SELECT CAST(@@IDENTITY as int)";

            // We can log query for debugging if required.  

            var parameters = new DynamicParameters();
                parameters.Add("Name", drug.Name, DbType.String);
                parameters.Add("DrugCode", drug.DrugCode, DbType.String);
                parameters.Add("IsQualified", drug.IsQualified, DbType.Boolean);
                parameters.Add("ManufactureDate", drug.ManufactureDate, DbType.DateTime);

            using (var connection = context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                var objDrug = new Drug
                {
                    Id = id,
                    Name = drug.Name,
                    DrugCode = drug.DrugCode,
                    IsQualified = drug.IsQualified,
                    ManufactureDate=drug.ManufactureDate
                };
                logger.LogInformation("Exit: DrugReposiotry.Add");
                return objDrug;
            }

            
        }

        public async Task<int> Delete(int id)
        {
            logger.LogInformation("Enter: DrugReposiotry.Delete");
            int noOfRowsDeleted = 0;
            var query = "DELETE FROM DRUGS WHERE Id = @Id";
            using (var connection = context.CreateConnection())
            {
                noOfRowsDeleted= await connection.ExecuteAsync(query, new { id });
            }
            logger.LogInformation("Exit: DrugReposiotry.Delete");
            return noOfRowsDeleted;
        }

        public async Task<Drug?> Get(int id)
        {
            logger.LogInformation("Enter: DrugReposiotry.Get");

            Drug? drug;
            var query = "SELECT * FROM DRUGS WHERE Id = @Id";
            using (var connection = context.CreateConnection())
            {
                drug = await connection.QuerySingleOrDefaultAsync<Drug?>(query, new { id });
                
            }

            logger.LogInformation("Exit: DrugReposiotry.Get");
            return drug;
        }

        public async Task<IEnumerable<Drug>> GetAll()
        {
            logger.LogInformation("Enter: DrugReposiotry.GetAll");

            IEnumerable<Drug> drugs ;
           
            var query = "SELECT * FROM DRUGS";
            using (var connection = context.CreateConnection())
            {
                 drugs = await connection.QueryAsync<Drug>(query);
                
            }
            logger.LogInformation("Exit: DrugReposiotry.GetAll");
            return drugs;
        }

        public async Task<int> Update(int id, DrugDTO drug)
        {
            logger.LogInformation("Enter: DrugReposiotry.Update");
            int noOfRowsAffected = 0;
            var query = "UPDATE DRUGS SET Name=@Name, DrugCode=@DrugCode, IsQualified=@IsQualified, ManufactureDate=@ManufactureDate WHERE Id = @Id";
            var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                parameters.Add("Name", drug.Name, DbType.String);
                parameters.Add("DrugCode", drug.DrugCode, DbType.String);
                parameters.Add("IsQualified", drug.IsQualified, DbType.Boolean);
                parameters.Add("ManufactureDate", drug.ManufactureDate, DbType.DateTime);

            using (var connection = context.CreateConnection())
            {
                noOfRowsAffected= await connection.ExecuteAsync(query, parameters);
            }
            logger.LogInformation("Exit: DrugReposiotry.Update");
            return noOfRowsAffected;
        }
    }
}
