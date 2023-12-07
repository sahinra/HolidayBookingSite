using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DummyPropertyRepository : IPropertyRepository
    {
        private static List<Property> properties = new List<Property>
        {
        new Property
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 15), EndDate = new DateTime(2023, 2, 20)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 3, 6), EndDate = new DateTime(2023, 4, 17)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 5, 14), EndDate = new DateTime(2023, 7, 6)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 7, 20), EndDate = new DateTime(2023, 11, 11)
                    }
                }

            },
        new Property
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 15), EndDate = new DateTime(2023, 2, 20)
                    }
                }
            },
        new Property
            {
                Id = 3,
                Name = "Great Forest House",
                Blurb = "A great home in the nature",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 15), EndDate = new DateTime(2023, 2, 20)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 15), EndDate = new DateTime(2023, 2, 20)
                    }
                }
            },
        new Property
            {
                Id = 4,
                Name = "Seaside Serenity",
                Blurb = "Charming beachfront property with stunning views",
                Location = "Malibu",
                NumberOfBedrooms = 4,
                CostPerNight = 500,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 15), EndDate = new DateTime(2023, 2, 20)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 3, 3), EndDate = new DateTime(2023, 4, 20)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 6, 2), EndDate = new DateTime(2023, 6, 4)
                    }
                }
            },

        new Property
            {
                Id = 5,
                Name = "Mountain Retreat",
                Blurb = "Cozy cabin nestled in the heart of the Rockies",
                Location = "Colorado",
                NumberOfBedrooms = 2,
                CostPerNight = 250,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 1, 1), EndDate = new DateTime(2023, 2, 25)
                    }
                }
            },

        new Property
            {
                Id = 6,
                Name = "Sunflower Villa",
                Blurb = "Mediterranean-style villa surrounded by sunflower fields",
                Location = "Tuscany",
                NumberOfBedrooms = 5,
                CostPerNight = 600,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 5, 15), EndDate = new DateTime(2023, 6, 20)
                    },
                    new BookedDates {
                        StartDate = new DateTime(2023, 7, 29), EndDate = new DateTime(2023, 8, 20)
                    }
                }
            },
        };

        //public IEnumerable<Property> Properties => properties;

        public void AddProperty(Property property)
        {
            property.Id = properties.Count + 1;
            properties.Add(property);
        }

        public IEnumerable<Property> GetProperties()
        {
            return properties;
        }
    }
}
