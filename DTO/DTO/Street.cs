using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Street
    {
        [Key]
        public int StreetId { get; set; }
        public string NameOfStreet { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
