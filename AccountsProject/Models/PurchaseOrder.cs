using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountsProject.Models
{
    public class PurchaseOrder : CreatedOrModified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PONumber { get; set; }

        public DateTime PODate { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalNet { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalGross { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalVat { get; set; }

        public int ForeignID { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public string Source { get; set; }
        public string SearchString { get; set; }
        public int CurrencyId { get; set; }
        public string Status { get; set; }
        public bool Void { get; set; }

        [ForeignKey("Supplier")]
        [Column(Order = 1)]
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
