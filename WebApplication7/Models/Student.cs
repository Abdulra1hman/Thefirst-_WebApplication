using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter your Description")]
        [StringLength(250)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Description")]
        [StringLength(250)]
        public string Email { get; set; }
    }
    // hjk
}
