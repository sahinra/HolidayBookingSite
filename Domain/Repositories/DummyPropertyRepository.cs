using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    internal class DummyPropertyRepository : IPropertyRepository
    {
        private static List<Property> properties = new()
        {
        new ()
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350
            },
        new ()
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730
            },
        new ()
            {
                Id = 3,
                Name = "Great Forest House",
                Blurb = "A great home in the nature",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730
            },
        new ()
            {
                Id = 4,
                Name = "Seaside Serenity",
                Blurb = "Charming beachfront property with stunning views",
                Location = "Malibu",
                NumberOfBedrooms = 4,
                CostPerNight = 500
            },

        new ()
            {
                Id = 5,
                Name = "Mountain Retreat",
                Blurb = "Cozy cabin nestled in the heart of the Rockies",
                Location = "Colorado",
                NumberOfBedrooms = 2,
                CostPerNight = 250
            },

        new ()
            {
                Id = 6,
                Name = "Sunflower Villa",
                Blurb = "Mediterranean-style villa surrounded by sunflower fields",
                Location = "Tuscany",
                NumberOfBedrooms = 5,
                CostPerNight = 600
            },
        };

        public IEnumerable<Property> Properties => properties;
    }
}
