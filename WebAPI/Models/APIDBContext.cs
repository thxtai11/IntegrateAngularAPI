using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebAPI.Models
{
    public class APIDBContext:DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options)
        {
        }
   

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
