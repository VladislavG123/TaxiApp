using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSite.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiApp.DTO;

namespace TaxiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly TaxiContext context;

        public DriverController(TaxiContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(DriverDTO newClient)
        {
            if ((await context.Drivers.CountAsync(driver => driver.Email == newClient.Email)) != 0)
            {
                return StatusCode(409);
            }

            await context.Drivers.AddAsync(new Models.Driver { Name = newClient.Name, Email = newClient.Email });

            await context.SaveChangesAsync();

            return Ok();
        }
    }
}