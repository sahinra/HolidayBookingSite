using Domain.Entities;

namespace HolidayBookingSite.Models
{
    public class PropertySearchModel
    {
        public IEnumerable<Property> Properties { get; set; }
        public SearchMenuModel SearchMenuModel { get; set; }
    }
}
