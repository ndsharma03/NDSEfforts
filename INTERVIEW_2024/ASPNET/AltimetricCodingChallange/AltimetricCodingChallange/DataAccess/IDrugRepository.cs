using AltimerticCodeChallenge.DTO;
using AltimerticCodeChallenge.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AltimerticCodeChallenge.DataAccess
{
    public interface IDrugRepository
    {
       
            public Task<IEnumerable<Drug>> GetAll();
            public Task<Drug?> Get(int id);
            public Task<Drug> Add(DrugDTO drug);
            public Task<int> Update(int id, DrugDTO drug);
            public Task<int> Delete(int id);
            
        
    }
}
