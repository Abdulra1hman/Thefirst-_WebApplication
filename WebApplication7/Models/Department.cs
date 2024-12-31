using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter title")]
        [StringLength(250)]
        public string title { get; set; }

        [Required(ErrorMessage = "Please Enter your Description")]
        [StringLength(250)]
        public string description { get; set; }

        [Required(ErrorMessage = "Please Enter your Description")]
        [StringLength(250)]
        public string headOfDepartment { get; set; }
    }
}
