using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]

        public int Total { get; set; }
        [Required]

        public virtual Book Book { get; set; }
    }
}
