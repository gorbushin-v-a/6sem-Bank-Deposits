using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string NameOfBank { get; set; }
        public string Information { get; set; }
    }
}
