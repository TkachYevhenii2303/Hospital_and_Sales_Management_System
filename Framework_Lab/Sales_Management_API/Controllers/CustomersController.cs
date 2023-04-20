using Microsoft.AspNetCore.Mvc;
using Sales_Management_BLL.Data_transfers_Results.Request_Results_DTO;
using Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO;
using Sales_Management_BLL.Data_transfers_Results.Services_Results;

namespace Sales_Management_API.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersServices _Customers_Services;

        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ICustomersServices customers_Services, ILogger<CustomersController> logger)
        {
            _Customers_Services = customers_Services;
            _logger = logger;
        }

        [HttpGet("Get_all_Customers")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GET_Customers_Response_DTO>>> Get_all_Customers()
        {
            try
            {
                var result = await _Customers_Services.Get_all_Customers();
                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while getting all customers.");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("Get_the_Customer")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GET_Customers_Response_DTO>>> Get_Customer_ID(Guid ID)
        {
            try
            {
                var result = await _Customers_Services.Get_Customer_ID(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while getting the concrete customer.");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPost("Insert_the_Customer")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GET_Customers_Response_DTO>>> Insert_Customer(INSERT_Customers_Response_DTO customer)
        {
            try
            {
                var result = await _Customers_Services.Insert_Customers(customer);
                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while insert new customer.");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPut("Update_the_Customer")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GET_Customers_Response_DTO>>> Update_Customer(UPDATE_Customers_Response customer)
        {
            try
            {
                var result = await _Customers_Services.Update_Customers(customer);
                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while insert new customer.");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
