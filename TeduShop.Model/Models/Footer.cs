using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [StringLength(250)]
        public string ID { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}