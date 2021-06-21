using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharps_ent.Entity
{
    public class Deposit
    {
        [Key]
        public int DepositId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public int DepositorId { get; set; }

        [ForeignKey("DepositorId")]
        public Depositor Depositor { get; set; }
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public int BankId { get; set; }

        [ForeignKey("BankId")]
        public Bank Bank { get; set; }
        public int Percent { get; set; }
        public string Description { get; set; }
    }
}
