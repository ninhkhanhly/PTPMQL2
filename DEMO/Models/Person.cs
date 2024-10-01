using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Person
    {
        [Key]
        public string CCCD { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }






    }
}