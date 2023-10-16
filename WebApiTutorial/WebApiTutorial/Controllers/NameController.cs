using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTutorial.Data;

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
        private DataContext _context;

        public NameController(DataContext context)
        {
            _context = context;
        }

/// <summary>
/// text här
/// </summary>
/// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Name>>> Get()
        {

            return Ok(await _context.Names.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Name>> GetId(int id)
        {
            var name = await _context.Names.FindAsync(id);
            if (name == null)
                return BadRequest("No name found");
            return Ok(names);
        }

        [HttpPost]
        public async Task<ActionResult<List<Name>>> AddName(Name name)
        {
            _context.Names.Add(name);
            await _context.SaveChangesAsync();
            return Ok(await _context.Names.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Name>>> UpdateName(Name nameUpdate)
        {
           var name = await _context.Names.FindAsync(nameUpdate.Id);
            if (name == null)
                return BadRequest("No name found");

            name.FullName = nameUpdate.FullName;
            name.FirstName = nameUpdate.FirstName;
            name.LastName = nameUpdate.LastName;
            name.Place = nameUpdate.Place;

            await _context.SaveChangesAsync();

             return Ok(await _context.Names.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Name>>> Delete(int id)
        {
             var name = await _context.Names.FindAsync(id);
            if (name == null)
                return BadRequest("No name found");

            _context.Names.Remove(name);
            await _context.SaveChangesAsync();

            return Ok(await _context.Names.ToListAsync());
        }
    }
}
