using HolidayBookingSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayBookingSite.Controllers
{
    public class PropertyListingController : Controller
    {

        private static List<PropertyDetailsModel> properties = new List<PropertyDetailsModel>
        {
        new PropertyDetailsModel
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 1, 15), new DateTime(2023, 2, 20) }
            },
        new PropertyDetailsModel
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 2, 28), new DateTime(2023, 3, 20) }
            },
        new PropertyDetailsModel
            {
                Id = 3,
                Name = "Great Forest House",
                Blurb = "A great home in the nature",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 5, 15), new DateTime(2023, 5, 18) }
            },
        new PropertyDetailsModel
            {
                Id = 4,
                Name = "Seaside Serenity",
                Blurb = "Charming beachfront property with stunning views",
                Location = "Malibu",
                NumberOfBedrooms = 4,
                CostPerNight = 500,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 2, 13), new DateTime(2023, 3, 22) }
            },

        new PropertyDetailsModel
            {
                Id = 5,
                Name = "Mountain Retreat",
                Blurb = "Cozy cabin nestled in the heart of the Rockies",
                Location = "Colorado",
                NumberOfBedrooms = 2,
                CostPerNight = 250,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 1, 10), new DateTime(2023, 1, 18) }
            },

        new PropertyDetailsModel
            {
                Id = 6,
                Name = "Sunflower Villa",
                Blurb = "Mediterranean-style villa surrounded by sunflower fields",
                Location = "Tuscany",
                NumberOfBedrooms = 5,
                CostPerNight = 600,
                Description = "Add your property description here",
                Amenities = new List<string> { "Amenity 1", "Amenity 2", "Amenity 3" },
                BookedDates = new List<DateTime> { new DateTime(2023, 1, 6), new DateTime(2023, 1, 21) }
            },
        };
        public IActionResult Index()
        {
            return RedirectToAction("ListAvailable");
        }

        public IActionResult ListAll()
        {
            return RedirectToAction("ListAvailable");
        }

        public IActionResult ListAvailable(DateTime start, DateTime end)
        {
            List<DateTime> range = new List<DateTime>((end - start).Days);
            for (int i = 0; i < (end-start).Days; i++)
            {
                range.Add(start.AddDays(i));
            }
            var availableProperties = properties.Where(p => p.BookedDates.Intersect(range).Count() < 1);

            var startDate = start.Year == 1 ? DateTime.Now : start;
            var endDate = end.Year == 1 ? DateTime.Now.AddDays(7) : end;

            var searchMenuModel = new SearchMenuModel
            {
                StartDate = startDate,
                EndDate = endDate
            };

            var model = new PropertySearchModel
            {
                SearchMenuModel = searchMenuModel,
                Properties = availableProperties
            };

            return View("ListProperties", model);
        }

        [HttpGet]
        public IActionResult ViewPropertyDetails(int id)
        {
            var property = properties.Where(p => p.Id == id).FirstOrDefault();

            if (property == null)
            {
                return NotFound();
            }

            return View("ViewPropertyDetails", property);
        }

    }
}
