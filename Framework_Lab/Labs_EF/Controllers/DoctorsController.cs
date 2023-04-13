using Hospital_System.Data_transfer_objects.Response_Results;
using Hospital_System.Data_transfer_objects.Services_Interfaces.Interfaces;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.Controllers
{
    [ApiController]
    [Route("api/doctros")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsServices _Doctors_Services;

        public DoctorsController(IDoctorsServices doctors_Services)
        {
            _Doctors_Services = doctors_Services;
        }

        [HttpGet("Get_all_Employees")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Get_Doctors_Result_DTO>>> Get_all_Information()
        {
            try
            {
                var result = await _Doctors_Services.Get_all_Doctors();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("{ID}", Name = "Get_concrete_Employee")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Get_Doctors_Result_DTO>> Get_Employee_ID(Guid ID)
        {
            try
            {
                var result = await _Doctors_Services.Get_Doctor_ID(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPost("Insert_Employee")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Get_Doctors_Result_DTO>>> Insert_Doctor(Insert_Doctors_Result_DTO doctor)
        {
            try
            {
                var result = await _Doctors_Services.Insert_Doctors(doctor);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPut("Update_the_Employee")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Get_Doctors_Result_DTO>>> Update_Doctors(Update_Doctors_Result_DTO doctor)
        {
            try
            {
                var result = await _Doctors_Services.Update_Doctrors(doctor);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpDelete("{ID}", Name = "Delete_the_Employee")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Get_Doctors_Result_DTO>>> Delete_Doctors(Guid ID)
        {
            try
            {
                var result = await _Doctors_Services.Delete_Doctrors(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
