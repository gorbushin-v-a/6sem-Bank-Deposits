using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string NameOfEmployee { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
    }
}
