using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Employee : Person
    {
        [Key]
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
      






    }
}