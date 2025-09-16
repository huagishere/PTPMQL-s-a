using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPro.Models
{
    [Table("person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PersonId { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
