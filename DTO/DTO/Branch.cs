using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharps_ent.Entity
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public int BankId { get; set; }

        [ForeignKey("BankId")]
        public Bank Bank { get; set; }

        [ForeignKey("StreetId")]
        public int StreetId { get; set; }
        public Street Street { get; set; }
    }
}
