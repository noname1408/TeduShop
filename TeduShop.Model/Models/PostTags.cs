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
    [Table("PostTags")]
    public class PostTags:Auditable
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        public int TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Posts Posts { get; set; }
        [ForeignKey("TagID")]
        public virtual Tags Tags{ get; set; }
    }
}
