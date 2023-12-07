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

        public IActionResult RegisterPropertyForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterProperty(PropertyDetailsModel model)
        {
            return RedirectToAction("SuccessfullyRegistered");
        }

        public IActionResult SuccessfullyRegistered()
        {
            return View();
        }


        //public IActionResult AddProperty(
        //    int id,
        //    string name,
        //    string blurb,
        //    string location,
        //    int numberOfBedroom,
        //    decimal costPerNight,
        //    string description,
        //    List<string> amendities,
        //    List<DateTime> bookedDates)
        //{
        //    var newProperty = new PropertyDetailsModel
        //    {
        //        Id = id,
        //        Name = name,
        //        Blurb = blurb,
        //        Location = location,
        //        NumberOfBedrooms = numberOfBedroom,
        //        CostPerNight = costPerNight,
        //        Description = description,
        //        Amenities = amendities,
        //        BookedDates = bookedDates
        //    };

        //    return View(newProperty);
        //}
    }
}
