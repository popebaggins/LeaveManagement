using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Must be between 1 and 50")]
        public int NumberOfDays { get; set; }
        [Required]
        public int Period { get; set; }
        [Display(Name = "Leave Type")]
        public LeaveTypeVM? LeaveType { get; set; }
    }
}