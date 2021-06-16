using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
    }
}
