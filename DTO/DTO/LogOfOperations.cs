using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharps_ent.Entity
{
    public class LogOfOperations
    {
        [Key]
        public int OperationId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public int DepositorId { get; set; }

        [ForeignKey("DepositorId")]
        public Depositor Depositor { get; set; }
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public TypeOperation TypeOperation { get; set; }
        public int Quantity { get; set; }
    }
}
