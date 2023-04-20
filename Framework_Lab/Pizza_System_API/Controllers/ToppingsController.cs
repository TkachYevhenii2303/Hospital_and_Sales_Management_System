using Microsoft.AspNetCore.Mvc;
using Pizza_System_BLL.Entities;
using Pizza_System_BLL.Repositories.Interfaces;

namespace Pizza_System_API.Controllers
{
    [ApiController]
    [Route("api/toppings")]
    public class ToppingsController : ControllerBase
    {
        private readonly IUnit_of_Work _Unit_of_Work;

        public ToppingsController(IUnit_of_Work unit_of_Work)
        {
            _Unit_of_Work = unit_of_Work;
        }

        [HttpGet("Get_all_Pizza")]
        public async Task<ActionResult<IEnumerable<Toppings>>> Get_all_Toppings()
        {
            try
            {
                return Ok(await _Unit_of_Work._Toppings_Repository.Get_all_Information());
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpGet("Get_pizza")]
        public async Task<ActionResult<Toppings>> Get_toppings(Guid ID)
        {
            try
            {
                return Ok(await _Unit_of_Work._Toppings_Repository.Get_information_ID(ID));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpPost("Insert_pizza")]
        public async Task<ActionResult<IEnumerable<Toppings>>> Insert_toppings(Toppings toppings)
        {
            try
            {
                return Ok(await _Unit_of_Work._Toppings_Repository.Insert_Entity(toppings));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpPut("Update_pizza")]
        public async Task<ActionResult<IEnumerable<Toppings>>> Update_toppings(Toppings toppings)
        {
            try
            {
                return Ok(await _Unit_of_Work._Toppings_Repository.Update_Entity(toppings));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }

        [HttpDelete("Delete_pizza")]
        public async Task<ActionResult<IEnumerable<Toppings>>> Delete_toppings(Guid ID)
        {
            try
            {
                return Ok(await _Unit_of_Work._Toppings_Repository.Delete_Entity(ID));
            }
            catch (Exception exceptions)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exceptions.Message);
            }
        }
    }
}   
