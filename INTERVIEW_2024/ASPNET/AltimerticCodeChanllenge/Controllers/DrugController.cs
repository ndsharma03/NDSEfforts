using AltimerticCodeChanllenge.DataAccess;
using AltimerticCodeChanllenge.DTO;
using AltimerticCodeChanllenge.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using static Dapper.SqlMapper;

namespace AltimerticCodeChanllenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DrugController : ControllerBase
    {
        private readonly IDrugRepository repository;
        private readonly ILogger<DrugController> logger;

        public DrugController(IDrugRepository repository,ILogger<DrugController>logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        //--> ***********************
            // We have multiple options for StatusCodes, based on requiement we can change and return required status code from an endpoint.
            // for example : instead of returning NotFound() from put/delete api , client may ask to return 'NoOfAffectedRows' from operation;
            // - with success status code.
        //***************************
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAll()
        {
            logger.LogInformation("Enter: DrugController.GetAll()");
            
            var result= await repository.GetAll();

            logger.LogInformation("Exit: DrugController.GetAll()");
            return Ok(result);
        }

        
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Get(int id)
        {
            logger.LogInformation("Enter: DrugController.Get()");

            Drug? drug = await repository.Get(id);
            
            logger.LogInformation("Exit: DrugController.Get()");
            return drug == null ? NotFound() : Ok(drug);
            
        }

        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Post( DrugDTO drugDto) 
        {
            logger.LogInformation("Enter: DrugController.Post()");

            var drug = await repository.Add(drugDto);

            logger.LogInformation("Exit: DrugController.Post()");
            return CreatedAtAction(nameof(Get), new { id = drug.Id }, drug);
           
        }

     
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Put(int id, [FromBody] DrugDTO drugDto)
        {
            logger.LogInformation("Enter: DrugController.Put()");

            var noofRowsAfftected = await repository.Update(id,drugDto);

            logger.LogInformation("Exit: DrugController.Put()");
            return noofRowsAfftected==0? NotFound(): NoContent();
        }

     
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(int id)
        {
            logger.LogInformation("Enter: DrugController.Delete()");

            var noofRowsdeleted = await repository.Delete(id);

            logger.LogInformation("Enter: DrugController.Delete()");
            return   noofRowsdeleted == 0 ? NotFound() : NoContent();
        }
    }
}
