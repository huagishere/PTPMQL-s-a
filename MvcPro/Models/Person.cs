using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPro.Models
{
    [Table("person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Point { get; set; } = string.Empty;
    }

    public class Employee : Person
    {
        [Required]
        public string EmployeeId { get; set; }

        public int Age { get; set; }
    }

    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP { get; set; }

        [Required]
        public string TenHTPP { get; set; }

    }

    public class DaiLy
    {
        [Key]
        public string MaDaiLy { get; set; }

        [Required]
        public string TenDaiLy { get; set; }

        public string DiaChi { get; set; }

        public string NguoiDaiDien { get; set; }

        public string DienThoai { get; set; }


        [ForeignKey("HeThongPhanPhoi")]
        public string MaHTPP { get; set; }
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}
