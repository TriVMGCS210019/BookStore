using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [Display(Name = "Title")]
        public string? Title { get; set; }
        [Required]
        [Display(Name = "Image" )]
        public string? Image { get; set; }
        [Required]
        public DateTime Update_date { get; set; }
        [Required]
        public string? Summary { get; set; }
        [Required]
        public int? Price { get; set; }
        //Relationships
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Categories { get; set; }
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
