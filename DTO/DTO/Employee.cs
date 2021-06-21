using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharps_ent.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string NameOfEmployee { get; set; }
        public int BankId { get; set; }

        [ForeignKey("BankId")]
        public Bank Bank { get; set; }
        public int StreetId { get; set; }

        [ForeignKey("StreetId")]
        public Street Street { get; set; }
    }
}
