using System;
using System.ComponentModel.DataAnnotations;

namespace MeterReadingProject.Models
{
    public class EmployeeRegistrationModel
    {
        public int users_id { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int Emp_Code { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Name { get; set; }
       

        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [StringLength(150, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [StringLength(150, MinimumLength = 6)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Emp_designation { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int BranchName { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int RegionName { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int ClusterName { get; set; }

        public int Role { get; set; }

        public string branch_name { get; set; }

        public string RoleName { get; set; }
    }
}
