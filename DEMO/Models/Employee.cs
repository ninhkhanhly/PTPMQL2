using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Employee : Person
    {
        [Key]
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }






    }
}