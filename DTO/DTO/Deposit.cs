using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Deposit
    {
        [Key]
        public int DepositId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int DepositorId { get; set; }
        public Depositor Depositor { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public int Percent { get; set; }
        public string Description { get; set; }
    }
}
