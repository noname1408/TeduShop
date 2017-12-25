using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abtracts;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetails:Auditable
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Orders Order { get; set; }

        public virtual IEnumerable<Orders> Orders { get; set; }

        [ForeignKey("ProductID")]
        public virtual  Product Product { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
