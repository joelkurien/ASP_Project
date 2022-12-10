using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security;
using System.Threading.Tasks;
using API.DataFiles;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //This is a GET Request
                                //access the link using api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;

        //dependency injection
        public UsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserClass>>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserClass>> GetUser(int id)
        {
            return await context.Users.FindAsync(id); //Find function is used to find primary id's
        }
    }
}