using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheGenerics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public Tour[] GetAllTours()
        {
            return TourDB.GetAllTours();
        }
    }
}
