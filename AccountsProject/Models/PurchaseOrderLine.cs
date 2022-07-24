using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountsProject.Models
{
    public class PurchaseOrderLine : CreatedOrModified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PoNumber")]
        public int PurchaseOrderLineID { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; } = null;
        public string PartNumber { get; set; }
        public decimal NetValue { get; set; }
        public decimal VatValue { get; set; }
        public decimal Value { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityReceived { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
