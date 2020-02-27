using RealEstates.Database;
using RealEstates.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.Application.Apartments
{
    class CreateApartment
    {
        private readonly ApplicationDbContext _context;

        public CreateApartment(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Do(int id, string description)
        {
            _context.Apartments.Add(new Apartment { Id = id, Description = description });


        }
    }
}
