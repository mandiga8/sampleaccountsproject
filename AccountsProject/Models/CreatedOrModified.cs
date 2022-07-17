using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AccountsProject.Models
{
    public abstract class CreatedOrModified
    {
        [Required]
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public int UserID { get; set; }

    }
}
