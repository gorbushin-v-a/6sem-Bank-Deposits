using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string NameOfStatus { get; set; }
    }
}
