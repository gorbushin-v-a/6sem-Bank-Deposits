using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharps_ent.Entity
{
    public class Street
    {
        [Key]
        public int StreetId { get; set; }
        public string NameOfStreet { get; set; }
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
