using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSite.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiApp.Models;

namespace TaxiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly TaxiContext context;

        public OrderController(TaxiContext context)
        {
            this.context = context;
        }

        /*[HttpPost]
        public async Task<IActionResult> Post(string clientEmail, string driverEmail, Location from, Location to)
        {
            var client = (await context.Clients.Where(client => client.Email == clientEmail).ToListAsync())[0];
            var driver = (await context.Drivers.Where(driver => driver.Email == driverEmail).ToListAsync())[0];
            
            if (driver is null || client is null)
            {
                return StatusCode(404);
            }

            await context.Orders.AddAsync(new Order { Client = client, Driver = driver, EndPosition = to, StartPosition = from });
            await context.SaveChangesAsync();

            return Ok();
        }
        */
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new { Test = "test" });
        }
    }
}
