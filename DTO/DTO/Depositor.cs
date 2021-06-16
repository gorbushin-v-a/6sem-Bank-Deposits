using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Depositor
    {
        [Key]
        public int DepositorId { get; set; }
        public string NameOfDepositor { get; set; }
        public string Position { get; set; }
    }
}
