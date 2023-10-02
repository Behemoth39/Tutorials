using Microsoft.AspNetCore.Mvc;

namespace WebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private static List<Name> names = new List<Name>
        {
            new Name {Id =1, FullName ="Simon Jonsson", FirstName= "Simon", LastName= "Jonsson", Place="Local" }
        };


        [HttpGet]
        public async Task<ActionResult<List<Name>>> Get()
        {

            return Ok(names);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Name>> GetId(int id)
        {
            var name = names.Find(e => e.Id == id);
            if (name == null)
                return BadRequest("No name found");
            return Ok(names);
        }

        [HttpPost]
        public async Task<ActionResult<List<Name>>> AddName(Name name)
        {
            names.Add(name);
            return Ok(names);
        }

        [HttpPut]
        public async Task<ActionResult<List<Name>>> UpdateName(Name nameUpdate)
        {
            var name = names.Find(e => e.Id == nameUpdate.Id);
            if (name == null)
                return BadRequest("No name found");

            name.FullName = nameUpdate.FullName;
            name.FirstName = nameUpdate.FirstName;
            name.LastName = nameUpdate.LastName;
            name.Place = nameUpdate.Place;

            return Ok(names);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Name>>> Delete(int id)
        {
            var name = names.Find(e => e.Id == id);
            if (name == null)
                return BadRequest("No name found");

            names.Remove(name);
            return Ok(names);
        }
    }
}
