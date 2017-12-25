using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abtracts;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Posts:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public int Warranty { get; set; }
        public string Description { get; set; }
        public int Content{ get; set; }
  
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public bool? ViewCount{ get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategories GetPostCategories{ get; set; }
    }
}
