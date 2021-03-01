using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DogDbContext : IdentityDbContext<IdentityUser>  
    {
        public DbSet<Dog> Dogs { get; set; }


        public DogDbContext(DbContextOptions<DogDbContext> options) : base(options)
        {
        }
    }
}

