using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}