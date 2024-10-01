using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }




    }
}