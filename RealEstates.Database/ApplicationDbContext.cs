using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstates.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.Database
{
   public class ApplicationDbContext : IdentityDbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Apartment> Apartments;
    }
}
