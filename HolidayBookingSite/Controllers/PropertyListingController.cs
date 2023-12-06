using HolidayBookingSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayBookingSite.Controllers
{
    public class PropertyListingController : Controller
    {

        private static List<PropertyListingModel> properties = new List<PropertyListingModel>
        {
        new PropertyListingModel
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350
            },
        new PropertyListingModel
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730
            },
        new PropertyListingModel
            {
                Id = 3,
                Name = "Great Forest House",
                Blurb = "A great home in the nature",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730
            },
        new PropertyListingModel
            {
                Id = 4,
                Name = "Seaside Serenity",
                Blurb = "Charming beachfront property with stunning views",
                Location = "Malibu",
                NumberOfBedrooms = 4,
                CostPerNight = 500
            },

        new PropertyListingModel
            {
                Id = 5,
                Name = "Mountain Retreat",
                Blurb = "Cozy cabin nestled in the heart of the Rockies",
                Location = "Colorado",
                NumberOfBedrooms = 2,
                CostPerNight = 250
            },

        new PropertyListingModel
            {
                Id = 6,
                Name = "Sunflower Villa",
                Blurb = "Mediterranean-style villa surrounded by sunflower fields",
                Location = "Tuscany",
                NumberOfBedrooms = 5,
                CostPerNight = 600
            },
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            return View("ListProperties", properties);
        }

        public IActionResult ListAvailable(DateTime start, DateTime end)
        {
            return View("ListProperties", properties);
        }

        [HttpGet]
        public IActionResult ViewPropertyDetails(int id)
        {
            return View();
        }

    }
}
