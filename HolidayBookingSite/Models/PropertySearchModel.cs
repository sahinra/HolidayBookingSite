namespace HolidayBookingSite.Models
{
    public class PropertySearchModel
    {
        public IEnumerable<PropertyListingModel> Properties { get; set; }
        public SearchMenuModel SearchMenuModel { get; set; }
    }
}
