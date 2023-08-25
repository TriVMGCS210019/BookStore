using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public DateTime Update_date { get; set; }
        [Required]
        public string? Summary { get; set; }
        [Required]
        public int? Price { get; set; }
        //Relationships
        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        /* [NotMapped]
         public List<Author> Authors { get; set; }
         [NotMapped]
         public List<Category> Categories { get; set; }
         [NotMapped]
         public List<OrderedBook> OrderedBooks { get; set; }

         //Category
         public Category Category { get; set; }
         //Author
         public Author Author { get; set; } */
    }
}
