using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var found = CitiesDataStore.Current.Cities.FirstOrDefault(o => o.Id == id);
            if (found == null)
            {
                return NotFound();
            }
            return Ok(found);
        }
    }
}