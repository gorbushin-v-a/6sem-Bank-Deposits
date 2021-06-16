using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string NameOfCountry { get; set; }
    }
}
