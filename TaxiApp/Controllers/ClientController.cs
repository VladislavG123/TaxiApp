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
    public class ClientController : ControllerBase
    {
        private readonly TaxiContext context;

        public ClientController(TaxiContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(ClientDTO newClient)
        {
            if((await context.Clients.CountAsync(client => client.Email == newClient.Email)) != 0)
            {
                return StatusCode(409);
            }

            await context.Clients.AddAsync(new Models.Client { Name = newClient.Name, Email = newClient.Email });

            await context.SaveChangesAsync();

            return Ok();
        }


    }
}