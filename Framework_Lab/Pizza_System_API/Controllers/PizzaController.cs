using Microsoft.AspNetCore.Mvc;
using Pizza_System_BLL.Entities;
using Pizza_System_BLL.Repositories.Interfaces;

namespace Pizza_System_API.Controllers
{
    [ApiController]
    [Route("api/pizza")]
    public class PizzaController : ControllerBase
    {
        private readonly IUnit_of_Work _Unit_of_Work;

        public PizzaController(IUnit_of_Work unit_of_Work)
        {
            _Unit_of_Work = unit_of_Work;
        }

        [HttpGet("Get_all_Pizza")]
        public async Task<ActionResult<IEnumerable<Pizza>>> Get_all_Pizza()
        {
            try
            {
                return Ok(await _Unit_of_Work._Pizza_Repository.Get_all_Information());
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpGet("Get_pizza")]
        public async Task<ActionResult<Pizza>> Get_pizza(Guid ID)
        {
            try
            {
                return Ok(await _Unit_of_Work._Pizza_Repository.Get_information_ID(ID));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpPost("Insert_pizza")]
        public async Task<ActionResult<IEnumerable<Pizza>>> Insert_pizza(Pizza pizza)
        {
            try
            {
                return Ok(await _Unit_of_Work._Pizza_Repository.Insert_Entity(pizza));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpPut("Update_pizza")]
        public async Task<ActionResult<IEnumerable<Pizza>>> Update_pizza(Pizza pizza)
        {
            try
            {
                return Ok(await _Unit_of_Work._Pizza_Repository.Update_Entity(pizza));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpDelete("Delete_pizza")]
        public async Task<ActionResult<IEnumerable<Pizza>>> Delete_pizza(Guid ID)
        {
            try
            {
                return Ok(await _Unit_of_Work._Pizza_Repository.Delete_Entity(ID));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }
    }
}
