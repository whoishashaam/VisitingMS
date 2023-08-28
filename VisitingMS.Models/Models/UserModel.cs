using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitingMS.Models
{
    public class UserModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1000000000000, 9999999999999, ErrorMessage = "CNIC must be 13 digits.")]
        public long CNIC { get; set; }

        [Required]
        [ValidateNever]
        public long PhoneNo { get; set; }
        [Required]
        public string? FullName { get; set; }

        [Required]
        public DateTime? EntryTime { get; set; }

       

        [Required]
        public string? VisitorBelongings { get; set; }

        [Required]
        public string? VisitingPurpose { get; set; }


        [ValidateNever]
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        [ValidateNever]
        public DepartmentModel Department { get; set; }


        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
