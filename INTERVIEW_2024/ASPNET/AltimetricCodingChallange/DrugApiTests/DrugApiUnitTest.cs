using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NuGet.Frameworks;

namespace DrugApiTests
{
    public class DrugApiUnitTest
    {

        // Below I have written only few test cases due to time constraint.
        // Ideally we need to write test cases to cover each and every scenario(Full code coverage).  

        private readonly Mock<IDrugRepository> drugRepository;
        private readonly Mock<ILogger<DrugController>> moqLogger;
        ILogger<DrugController> logger;
        public DrugApiUnitTest()
        {
            drugRepository = new Mock<IDrugRepository>();
            moqLogger = new Mock<ILogger<DrugController>>();
            logger = moqLogger.Object;
        }
        [Fact]
        public async Task GetAll_DrugsList()
        {
            //arrange
            var drugs = GetAllDrugs();
                
            drugRepository.Setup(x => x.GetAll()).ReturnsAsync(drugs);

            var drugController = new DrugController(drugRepository.Object,logger);
            //act
            var resultfromController = await drugController.GetAll();
            //assert
            var okResult = resultfromController as OkObjectResult;
            IEnumerable<Drug>? result = okResult?.Value as IEnumerable<Drug>;

            // assert
            Assert.NotNull(okResult);
            Assert.NotNull(okResult.Value);
            Assert.Equal(200, okResult.StatusCode);
            Assert.NotNull(result);
            Assert.Equal(result.Count(), drugs.Count());

            
            
        }
        [Fact]
        public async Task GetDrugByID_Drug()
        {
            //arrange
            var drugs = GetAllDrugs();

            drugRepository.Setup(x => x.Get(2)).ReturnsAsync(drugs[2]);

            var drugController = new DrugController(drugRepository.Object, logger);
            //act
            var okResult = await drugController.Get(2) as OkObjectResult;
           
           var result = okResult?.Value as Drug;
            //assert
            Assert.NotNull(okResult);
            Assert.NotNull(result);
       
            Assert.Equal(drugs[2].Id, result.Id);
            
        }


        [Fact]
        public async Task AddDrug_DrugWithId()
        {            //arrange
            var drugs = GetAllDrugs();
            var drugtoAdd = new DrugDTO { Name = "TestDrug", DrugCode = "Test01", IsQualified = false, ManufactureDate = new DateTime(2024, 06, 01) };

            drugRepository.Setup(x => x.Add(drugtoAdd)).ReturnsAsync(
                    new Drug {Id=999, Name = "TestDrug", DrugCode = "Test01", IsQualified = false, ManufactureDate = new DateTime(2024, 06, 01) });

            var drugController = new DrugController(drugRepository.Object, logger);
            //act
            var result = await drugController.Post(drugtoAdd) as CreatedAtActionResult;

            var drug = result?.Value as Drug;
            //assert
            Assert.NotNull(result);
            Assert.NotNull(drug);
            Assert.Equal(drugtoAdd.Name,drug.Name);
            Assert.Equal(999,drug.Id);
        }

        private List<Drug> GetAllDrugs()
        {
            List<Drug> drugs = new List<Drug>
            {
             new Drug { Id = 1, Name = "Drug A", DrugCode = "A123", IsQualified = true, ManufactureDate = DateTime.Now },
             new Drug { Id = 2, Name = "Drug B", DrugCode = "B456", IsQualified = true, ManufactureDate = DateTime.Now },
             new Drug { Id = 3, Name = "Drug c", DrugCode = "C151", IsQualified = true, ManufactureDate = DateTime.Now }
            };
            return drugs;
        }
    }
}