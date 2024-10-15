namespace DropdownlistHtmlHelperInAspNetCoreMvc.Models;
public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public int DepartmentID { get; set; }
}