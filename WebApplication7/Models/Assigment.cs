using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class Assigment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter your title")]
        [StringLength(250)]
        public string title { get; set; }

        [Required(ErrorMessage = "Please Enter your Description")]
        [StringLength(250)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please Enter your StarDate")]
        [StringLength(250)]
        public string StarDate { get; set; }

        [Required(ErrorMessage = "Please Enter your EndDate")]
        [StringLength(250)]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "Please Enter your statues")]
        [StringLength(250)]
        public string statues { get; set; }

        [ForeignKey("departmentId")]
        public int departmentId { get; set; }
        public Department department { get; set; }

        [ForeignKey("studentId")]
        public int studentId { get; set; }
        public Student student { get; set; }

    }
}
