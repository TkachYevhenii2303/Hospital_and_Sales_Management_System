using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Labs_EF.Controllers
{
    [ApiController]
    [Route("api/doctros")]
    public class DoctorsController : ControllerBase
    {
        private readonly IUnit_of_Work _Unit_of_Work;

        public DoctorsController(IUnit_of_Work unit_of_Work)
        {
            _Unit_of_Work = unit_of_Work;
        }

        [HttpGet("Ger_all_Employees")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServicesResponse<Doctors>>>> Get_all_Information()
        {
            try
            {
                var result = await _Unit_of_Work.Doctros_Repository.Get_all_Information();
                _Unit_of_Work.Complete();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("Get_concrete_Employee")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServicesResponse<Doctors>>>> Get_Employee_ID(Guid ID)
        {
            try
            {
                var result = await _Unit_of_Work.Doctros_Repository.Get_information_ID(ID);
                _Unit_of_Work.Complete();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPost("Post_Employee_to_List")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServicesResponse<Doctors>>>> Post_Employee(Doctors doctors)
        {
            try
            {
                var result = await _Unit_of_Work.Doctros_Repository.Insert_Entity(doctors);
                _Unit_of_Work.Complete();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
