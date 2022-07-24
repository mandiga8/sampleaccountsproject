using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountsProject.Models
{
    public abstract class CreatedOrModified
    {
        [Required]
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        //[ForeignKey("User")]
        public int CreatedUserID { get; set; }

        //[ForeignKey("User")]
        public int ModifiedUserID { get; set; }
    }
}
