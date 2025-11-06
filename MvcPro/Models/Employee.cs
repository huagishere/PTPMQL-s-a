using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcPro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? MaHTPP { get; set; }
        public string? TenHTPP { get; set; }

    }
}