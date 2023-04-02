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

        [HttpGet("GET_all_Information")]
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
    }
}
