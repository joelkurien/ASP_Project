using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//database tables
namespace API.Entities
{
    public class UserClass
    {
        public int Id { get; set; }

        public string UserName { get; set; }
    }
}