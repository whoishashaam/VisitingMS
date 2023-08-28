using System.ComponentModel.DataAnnotations;

namespace VisitingMS.Models
{
    public class DepartmentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? DepartmentName { get; set; }

        [Required]
        public string? HOD { get; set; }

    }
}
