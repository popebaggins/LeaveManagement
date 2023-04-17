namespace LeaveManagement.Common.Models
{
    public class EditLeaveAllocationVM : LeaveAllocationVM
    {
        public EmployeeListVM? Employee { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }
    }
}
