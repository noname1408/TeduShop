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
    [Table("SystemConfig")]
    public class SystemConfig:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int ValueInt { get; set; }
    }
}
