namespace TextboxHtmlHelperInAspNetCoreMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public decimal Salary { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}