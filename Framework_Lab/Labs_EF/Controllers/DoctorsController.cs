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
    }
}
