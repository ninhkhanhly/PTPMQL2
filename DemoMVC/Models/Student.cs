using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student{
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        
        
        
        
    }
}