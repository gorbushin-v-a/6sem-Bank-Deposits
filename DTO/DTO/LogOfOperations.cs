using System.ComponentModel.DataAnnotations;

namespace sharps_ent.Entity
{
    public class LogOfOperations
    {
        [Key]
        public int OperationId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int DepositorId { get; set; }
        public Depositor Depositor { get; set; }
        public int TypeId { get; set; }
        public TypeOperation TypeOperation { get; set; }
        public int Quantity { get; set; }
    }
}
