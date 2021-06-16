using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string NameOfCity { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
