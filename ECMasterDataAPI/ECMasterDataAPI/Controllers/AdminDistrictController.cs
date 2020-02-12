using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECMasterDataAPI.Models.StoredProceduers;
using ECMasterDataAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECMasterDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDistrictController : ControllerBase
    {
        private readonly VotRegContext _context;

        public AdminDistrictController(VotRegContext context)
        {
            _context = context;
        }
        // GET: api/admindistrict
        [HttpGet]
        public async Task<List<SpAdminDistricts>> Get()
        {
            return await _context.GetAdminDistrictsAsync();
        }

        [HttpGet("{id}")]
        public async Task<List<SpAdminDistricts>> GetById(int id)
        {
            return await _context.GetAdminDistrictByIdAsync(id);
        }


    }
}