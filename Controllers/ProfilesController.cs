using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AddressBookAPI.Data;
using AddressBookAPI.Models;

namespace AddressBookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfilesController(AddressBookContext _context) : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> GetProfiles()
        {
            return await _context.Profiles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetProfile(int id)
        {
            var profile = await _context.Profiles.FindAsync(id);
            return profile == null ? NotFound() : profile;
        }
    }
}

