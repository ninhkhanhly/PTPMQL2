using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NetMVC.Models.Entity
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }




    }
}