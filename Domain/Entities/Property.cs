using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Blurb { get; set; }
        public string Location { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal CostPerNight { get; set; }
        public string Description { get; set; }
        public List<string> Amenities { get; set; }
        public List<BookedDates> BookedDates { get; set; }
        public bool IsAvailable(DateTime start, DateTime end)
        {
            return !BookedDates.Any(b => start < b.EndDate && end > b.StartDate);
        }
    }
}
