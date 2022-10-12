using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequireDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Freight { get; set; }
        
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
    }
}