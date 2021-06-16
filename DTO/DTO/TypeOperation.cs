using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class TypeOperation
    {
        [Key]
        public int TypeId { get; set; } 
        public string NameOfType { get; set; }
        public string Action { get; set; }
    }
}
