using System.ComponentModel.DataAnnotations;

namespace AttainTaskSupportSystem.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string role { get; set; } = "staff";
    }
}
