using Domain.Entities;
using Domain.Repositories;
using HolidayBookingSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayBookingSite.Controllers
{
    public class PropertyManagementController : Controller
    {
        IPropertyRepository propertyRepository;

        public PropertyManagementController(IPropertyRepository propertyRepository)
        {
            this.propertyRepository = propertyRepository;
        }

        public IActionResult RegisterProperty()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterProperty(PropertyDetailsModel model)
        {
            var newProperty = new Property
            {
                Name = model.Name,
                Blurb = model.Blurb,
                Location = model.Location,
                NumberOfBedrooms = model.NumberOfBedrooms,
                CostPerNight = model.CostPerNight,
                Description = model.Description,
                Amenities = model.Amenities,
                BookedDates = new List<BookedDates>
                {
                    new BookedDates {
                        StartDate = new DateTime(2023, 5, 15), EndDate = new DateTime(2023, 6, 20)
                    }
                }
            };
            propertyRepository.AddProperty(newProperty);

            return RedirectToAction("SuccessfullyRegistered");
        }

        public IActionResult SuccessfullyRegistered()
        {
            return View();
        }
    }
}
