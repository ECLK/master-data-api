using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECMasterDataAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECMasterDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollingDistrictController : ControllerBase
    {
        private readonly VotRegContext _context;

        public PollingDistrictController(VotRegContext context)
        {
            _context = context;
        }
        // GET: api/PollingDistrict
        [HttpGet]
        public async Task<List<PollingDistrict>> Get()
        {
            return await _context.PollingDistricts.ToListAsync();
        }

        // GET: api/PollingDistrict/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            PollingDistrict district = await _context.PollingDistricts.FirstOrDefaultAsync(dis => dis.Pdid == id);
            if(district == null)
            {
                return NotFound();
            }

            return Ok(district);
        }

        // POST: api/PollingDistrict
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PollingDistrict/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
