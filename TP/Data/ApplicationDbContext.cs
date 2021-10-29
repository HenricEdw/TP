using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TP.Models;

namespace TP.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<TP.Models.Company> Company { get; set; }
        public DbSet<TP.Models.Booking> Booking { get; set; }
        public DbSet<TP.Models.Room> Room { get; set; }
    }
}
