namespace RadiobuttonHtmlHelperInAspNetCoreMvc.Models;
public class Company
    {
        public int SelectedDepartment { get; set; }
        public List<Department> Departments()
        {
            List<Department> ListDepartments = new List<Department>()
            {
                    new Department() {Id = 1, Name="IT" },
                    new Department() {Id = 2, Name="HR" },
                    new Department() {Id = 3, Name="Manager" },
            };
            return ListDepartments;
        }
    }