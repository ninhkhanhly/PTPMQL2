using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NetMVC.Models.Entity
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string FullName { get; set; }




    }
}