namespace EditorHtmlHelperInAspNetCoreMvc.Models;
public class Employee
{
    public string? Name { get; set; }         // string
    public int Age { get; set; }             // int
    public decimal Salary { get; set; }      // decimal
    public bool IsEmployed { get; set; }     // bool
    public DateTime DateOfBirth { get; set; } // DateTime
    public List<string>? Skills { get; set; } // List<string>
    public Gender Gender { get; set; }       // Enum
    public IFormFile? ProfilePicture { get; set; } // IFormFile
    public Guid UserId { get; set; }         // Guid
    public TimeSpan WorkingHours { get; set; } // TimeSpan
}
public enum Gender
{
    Male,
    Female,
    Other
}