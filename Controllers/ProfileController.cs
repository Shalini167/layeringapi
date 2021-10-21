using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProfileAPI.Models;
using ProfileAPI.Service;

namespace ProfileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly pharmvcContext db;
        private readonly ICustomerService<CustomerDetail> serv2;
        public ProfileController(ICustomerService<CustomerDetail> _serv2,pharmvcContext _db)
        {
            serv2 = _serv2;
            db = _db;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ViewProfile(int id)
        {
            CustomerDetail cd = serv2.ViewProfile(id);
            return Ok(cd);
            //CustomerDetail c = await db.CustomerDetails.FindAsync(id);
       
        }
        [HttpPut]
        public async Task<IActionResult> EditProfile(int id, CustomerDetail c)
        {
            serv2.EditProfile(id, c);
            //db.Entry(c).State = EntityState.Modified;
            //await db.SaveChangesAsync();
            return Ok();
        }
    }
}
