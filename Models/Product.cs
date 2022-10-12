using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Weight { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsnlStock { get; set; }
    }
}