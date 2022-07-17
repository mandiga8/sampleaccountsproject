using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountsProject.Models
{
    [Index(nameof(Supplier.Name), IsUnique =true)]
    [Index(nameof(Supplier.Phone), IsUnique = true)]
    public class Supplier : CreatedOrModified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(200), MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(13)]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AccountRef { get; set; }
        public string Postcode { get; set; }
        public string VatReg { get; set; }
        public bool Void { get; set; }
    }
}