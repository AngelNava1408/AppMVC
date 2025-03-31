using System.ComponentModel.DataAnnotations;

namespace UserManagementApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
    }
}
